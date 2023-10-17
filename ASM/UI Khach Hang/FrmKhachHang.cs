using ASM.Core.Context;
using ASM.Core.Models;
using ASM.Core.Services.KhachHang;
using ASM.UI_Đăng_Nhập;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ASM
{
    public partial class FrmKhachHang : Form
    {
        private List<classKhachHang> customerList; // Danh sách khách hàng
        private khachhangRepository khachhangRepo;
        private FrmMain frmMain;

        public FrmKhachHang(FrmMain mainForm)
        {
            InitializeComponent();
            customerList = new List<classKhachHang>();
            khachhangRepo = new khachhangRepository(new QLBH_Db_Contex()); // Đảm bảo bạn đã khởi tạo context
            frmMain = mainForm;
            // Khởi động ứng dụng và hiển thị danh sách khách hàng
            LoadCustomerList();
        }
        private void LoadCustomerList()
        {
            customerList = khachhangRepo.GetAllCustomer();
            dataGridViewKhachhang.DataSource = customerList;
            dataGridViewKhachhang.Columns["name"].HeaderText = "Tên Khách Hàng";

        }
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            rbtNam.Checked = true; // Mặc định chọn giới tính nam
            DisableCustomerInfoInput();
        }
        private void DisplayData()
        {
            /*dataGridViewKhachhang.DataSource = null;
            dataGridViewKhachhang.DataSource = _FlowerSvc.GetAllFlowers();*/
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            rtxtAddress.Enabled = true;
            groupBox1.Enabled = true;
        }
        private void DisableCustomerInfoInput()
        {
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            rtxtAddress.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewKhachhang.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                string phoneNumber = customerList[rowIndex].DienThoai;

                // Xóa khách hàng khỏi cơ sở dữ liệu và danh sách
                khachhangRepo.DeleteCustommer(phoneNumber);
                customerList.RemoveAt(rowIndex);
                MessageBox.Show("Xóa thành công");

                // Cập nhật DataGridView
                dataGridViewKhachhang.DataSource = null;
                dataGridViewKhachhang.DataSource = customerList;
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewKhachhang.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(rtxtAddress.Text))
                {
                    // Lấy thông tin từ TextBox và RadioButton
                    string phoneNumber = customerList[rowIndex].DienThoai;
                    string name = txtName.Text;
                    string address = rtxtAddress.Text;
                    byte gender = rbtNam.Checked ? (byte)1 : (byte)0; // 1 là nam, 0 là nữ

                    // Tạo đối tượng khách hàng mới
                    var updatedCustomer = new classKhachHang
                    {
                        DienThoai = phoneNumber,
                        Name = name,
                        DiaChi = address,
                        Phai = gender,
                        MaNV = "", // Thay đổi để phù hợp với cấu trúc dữ liệu
                    };

                    // Cập nhật thông tin khách hàng vào cơ sở dữ liệu
                    khachhangRepo.UpdaterCustommer(updatedCustomer);

                    // Cập nhật danh sách khách hàng và DataGridView
                    customerList[rowIndex] = updatedCustomer;
                    dataGridViewKhachhang.DataSource = null;
                    dataGridViewKhachhang.DataSource = customerList;
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin.");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng muốn sửa.");
            }
        }

        private void btSkip_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewKhachhang.CurrentCell.RowIndex;
            if (rowIndex < customerList.Count - 1)
            {
                rowIndex++;
                dataGridViewKhachhang.CurrentCell = dataGridViewKhachhang.Rows[rowIndex].Cells[0];
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtFindPhonenumber.Text;

            // Tìm khách hàng trong danh sách
            List<classKhachHang> foundCustomers = khachhangRepo.SearchEmployees(phoneNumber);

            // Cập nhật DataGridView với danh sách khách hàng tìm thấy
            dataGridViewKhachhang.DataSource = null;
            dataGridViewKhachhang.DataSource = foundCustomers;
        }

        private void btShowList_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhone.Text;
            string name = txtName.Text;
            string address = rtxtAddress.Text;
            byte gender = rbtNam.Checked ? (byte)1 : (byte)0; // 1 là nam, 0 là nữ

            // Tạo đối tượng khách hàng mới
            var newCustomer = new classKhachHang
            {
                DienThoai = phoneNumber,
                Name = name,
                DiaChi = address,
                Phai = gender,
                MaNV = frmMain.MaNhanVien, // Lấy mã nhân viên từ frmMain
            };

            // Thêm khách hàng mới vào danh sách và cơ sở dữ liệu
            khachhangRepo.AddCustommer(newCustomer);
            customerList.Add(newCustomer);

            // Cập nhật DataGridView
            dataGridViewKhachhang.DataSource = null;
            dataGridViewKhachhang.DataSource = customerList;
        }

        private void dataGridViewKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            rtxtAddress.Enabled = true;
            groupBox1.Enabled = true;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewKhachhang.Rows[e.RowIndex];
                txtName.Text = selectedRow.Cells["name"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["dienthoai"].Value.ToString();
                rtxtAddress.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                int vaitroValue = Convert.ToInt32(selectedRow.Cells["phai"].Value);

                // Cập nhật RadioButton dựa trên giá trị Vaitro
                rbtNam.Checked = (vaitroValue == 1);
                rbtNu.Checked = (vaitroValue == 0);
                // Hiển thị thông tin trên các control
                groupBox1.Enabled = true;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
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
