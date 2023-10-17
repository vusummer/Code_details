using ASM.Core.Context;
using ASM.Core.Models;
using ASM.Core.Services.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BCrypt.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using ASM.UI_Đăng_Nhập;

namespace ASM.UI_Nhân_Viên
{
    public partial class FrmNhanVien : Form
    {
        private List<classNhanvien> staffList; // Danh sách nhân viên
        private nhanvienRepository nhanvienRepo;
        private FrmMain frmMain;
        /*private INhanvien _nhanvien;*/
        public FrmNhanVien(FrmMain mainForm)
        {
            InitializeComponent();
            staffList = new List<classNhanvien>();
            var context = new QLBH_Db_Contex(); // Khởi tạo context
            nhanvienRepo = new nhanvienRepository(context); // Khởi tạo nhanvienRepo với context
            frmMain = mainForm;
            LoadStaffList();
        }

        private void LoadStaffList()
        {
            staffList = nhanvienRepo.GetAllStaff();
            dataGridViewNhanVien.DataSource = staffList;
            dataGridViewNhanVien.Columns["Tennv"].HeaderText = "Tên Nhân Viên";
        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            rtxtAddress.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtEmail.Enabled = true;
            rtxtAddress.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;

        }
        private void btSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string tenNV = txtName.Text;
            string diaChi = rtxtAddress.Text;
            int vaitro = rbQL.Checked ? 1 : 0; // 1 là admin, 0 là nhân viên
            int tinhTran = rbHD.Checked ? 1 : 0; // 1 là hoạt động, 0 là ngừng hoạt động
            string matKhau = txtMatkhau.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
            else if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.");
            }
            else if (IsEmailExist(email))
            {
                MessageBox.Show("Email đã tồn tại. Vui lòng sử dụng email khác.");
            }
            else
            {
                var newStaff = new classNhanvien
                {
                    MaNV = GetNewEmpCode(),
                    Email = email,
                    TenNv = tenNV,
                    DiaChi = diaChi,
                    Vaitro = vaitro,
                    Tinhtran = tinhTran,
                    Matkhau = matKhau
                }; // Băm mật khẩu trước khi lưu vào cơ sở dữ liệu
               /* string hashedPassword = PasswordHasher.HashPassword(matKhau);

                var newStaff = new classNhanvien
                {
                    MaNV = GetNewEmpCode(),
                    Email = email,
                    TenNv = tenNV,
                    DiaChi = diaChi,
                    Vaitro = vaitro,
                    Tinhtran = tinhTran,
                    Matkhau = hashedPassword
                };*/
                // Thêm nhân viên mới vào danh sách và cơ sở dữ liệu
                nhanvienRepo.AddStaff(newStaff);
                staffList.Add(newStaff);
                //
                dataGridViewNhanVien.DataSource = null;
                dataGridViewNhanVien.DataSource = staffList;
            }
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        bool IsEmailExist(string email)
        {
            return staffList.Any(s => s.Email == email);
        }
        public string GetNewEmpCode()
        {
            if (staffList.Count() > 0)
            {
                List<string> myCodeList = staffList.Select(x => x.MaNV).ToList();
                List<int> myCode = myCodeList.Select(x => int.Parse(x.Substring(2))).ToList();
                int myNewCode = myCode.Max() + 1;
                if (myNewCode < 10)
                {
                    return "NV0" + myNewCode;
                }
                return "NV00" + myNewCode;
            }
            else
            {
                return "NV001";
            }

        }
        private void btDel_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewNhanVien.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                string maNV = staffList[rowIndex].MaNV;
                string tenNv = staffList[rowIndex].TenNv;
                // Xóa nhân viên khỏi cơ sở dữ liệu và danh sách
                nhanvienRepo.DeleteStaff(maNV);
                nhanvienRepo.DeleteStaff(tenNv);
                staffList.RemoveAt(rowIndex);
                MessageBox.Show("Xóa thành công");
                // Cập nhật DataGridView
                dataGridViewNhanVien.DataSource = null;
                dataGridViewNhanVien.DataSource = staffList;
                //vo hieu hoa khi xoa xong
                txtEmail.Text = "";
                txtFindname.Text = "";
                rtxtAddress.Text = "";
                txtMatkhau.Text = "";
                rbHD.Checked = false;
                rbNHD.Checked = false;
                rbNV.Checked = false;
                rbQL.Checked = false;
                txtName.Enabled = false;
                txtEmail.Enabled = false;
                rtxtAddress.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                //-----------------------------
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
                    
            int rowIndex = dataGridViewNhanVien.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtMatkhau.Text))
                {
                    // Lấy thông tin từ TextBox và RadioButton
                    string email = txtEmail.Text;
                    string tenNV = txtName.Text;
                    string diaChi = rtxtAddress.Text;
                    int vaitro = rbQL.Checked ? 1 : 0; // 1 là admin, 0 là nhân viên
                    int tinhTran = rbHD.Checked ? 1 : 0; // 1 là hoạt động, 0 là ngừng hoạt động
                    string matKhau = txtMatkhau.Text;

                    // Tạo đối tượng nhân viên mới
                    var updatedStaff = new classNhanvien
                    {
                        MaNV = staffList[rowIndex].MaNV, // Giữ nguyên mã nhân viên
                        Email = email,
                        TenNv = tenNV,
                        DiaChi = diaChi,
                        Vaitro = vaitro,
                        Tinhtran = tinhTran,
                        Matkhau = matKhau
                    };
                    /*
                    // Băm mật khẩu trước khi lưu vào cơ sở dữ liệu
                    string matKhau = txtMatkhau.Text;
                    string hashedPassword = PasswordHasher.HashPassword(matKhau);

                    // Tạo đối tượng nhân viên mới
                    var updatedStaff = new classNhanvien
                    {
                        MaNV = staffList[rowIndex].MaNV,
                        Email = email,
                        TenNv = tenNV,
                        DiaChi = diaChi,
                        Vaitro = vaitro,
                        Tinhtran = tinhTran,
                        Matkhau = hashedPassword
                    };*/

                    // Cập nhật thông tin nhân viên vào cơ sở dữ liệu
                    nhanvienRepo.UpdaterStaff(updatedStaff);

                    // Cập nhật danh sách nhân viên và DataGridView
                    staffList[rowIndex] = updatedStaff;
                    dataGridViewNhanVien.DataSource = null;
                    dataGridViewNhanVien.DataSource = staffList;
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin.");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên muốn sửa.");
            }
        }

        private void btSkip_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewNhanVien.CurrentCell.RowIndex;
            if (rowIndex < staffList.Count - 1)
            {
                rowIndex++;
                dataGridViewNhanVien.CurrentCell = dataGridViewNhanVien.Rows[rowIndex].Cells[0];
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txtFindname.Text;

            // Tìm nhân viên trong danh sách
            List<classNhanvien> foundStaff = nhanvienRepo.SearchStaffs(tenNhanVien);

            // Cập nhật DataGridView với danh sách nhân viên tìm thấy
            dataGridViewNhanVien.DataSource = null;
            dataGridViewNhanVien.DataSource = foundStaff;
        }

        private void btShowList_Click(object sender, EventArgs e)
        {
            LoadStaffList();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Enabled = true;
            txtEmail.Enabled = true;
            rtxtAddress.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewNhanVien.Rows[e.RowIndex];
                txtName.Text = selectedRow.Cells["Tennv"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                rtxtAddress.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtMatkhau.Text = selectedRow.Cells["matkhau"].Value.ToString();
                int vaitroValue = Convert.ToInt32(selectedRow.Cells["Vaitro"].Value);

                // Cập nhật RadioButton dựa trên giá trị Vaitro
                rbQL.Checked = (vaitroValue == 1);
                rbNV.Checked = (vaitroValue == 0);

                // Tương tự, làm tương tự cho RadioButton Tinhtran
                int tinhTranValue = Convert.ToInt32(selectedRow.Cells["Tinhtran"].Value);
                rbHD.Checked = (tinhTranValue == 1);
                rbNHD.Checked = (tinhTranValue == 0);

                // Hiển thị thông tin trên các control
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo hỏi người dùng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                string ten = frmMain.loggedInUser;
                int role = frmMain.userRole;
                string ma = frmMain.MaNhanVien;
                FrmMain frmMain1 = new FrmMain(ten, role, ma);
                frmMain1.ShowDialog();
            }
        }

    }
}
