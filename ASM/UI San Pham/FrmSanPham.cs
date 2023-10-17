using ASM.Core.Context;
using ASM.Core.Models;
using ASM.Core.Services.NhanVien;
using ASM.Core.Services.sanpham;
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

namespace ASM
{
    public partial class FrmSanPham : Form
    {
        private List<classSanpham> HangList; // Danh sách nhân viên
        private sanphamRepository sanphamRepository;
        private FrmMain frmMain;
        public FrmSanPham(FrmMain mainForm)
        {
            InitializeComponent();
            HangList = new List<classSanpham>();
            var context = new QLBH_Db_Contex(); // Khởi tạo context
            sanphamRepository = new sanphamRepository(context);
            frmMain = mainForm;
            LoadSanPham();
        }
        private void LoadSanPham()
        {
            HangList = sanphamRepository.GetAllProducts();
            dataGridViewsanpham.DataSource = HangList;

        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtCode.Enabled = true;
            txtDonGia.Enabled = true;
            txtDonGiaban.Enabled = true;
            txtSl.Enabled = true;
            btOpen.Enabled = true;
            btSave.Enabled = true;
            btDel.Enabled = true;
            btEdit.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string tenHang = txtName.Text;
            int maHang = int.Parse(txtCode.Text);
            int soLuong = int.Parse(txtSl.Text);
            float donGiaNhap = float.Parse(txtDonGia.Text);
            float donGiaBan = float.Parse(txtDonGiaban.Text);
            string hinhAnh = txtHinh.Text;
            string ghiChu = richTextBox1.Text;
            string maNV = frmMain.MaNhanVien;

            // Tạo đối tượng sản phẩm mới
            var newProduct = new classSanpham
            {
                TenHang = tenHang,
                MaHang = maHang,
                soluong = soLuong,
                dongianhap = donGiaNhap,
                dongiaban = donGiaBan,
                hinhanh = hinhAnh,
                ghichu = ghiChu,
                MaNV = maNV
            };

            // Thêm sản phẩm mới vào cơ sở dữ liệu
            sanphamRepository.AddProduct(newProduct);

            // Cập nhật DataGridView
            dataGridViewsanpham.DataSource = null;
            dataGridViewsanpham.DataSource = sanphamRepository.GetAllProducts();
        }

        private void dataGridViewsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewsanpham.Rows[e.RowIndex];

                // Lấy thông tin sản phẩm từ dòng được chọn
                string maHang = row.Cells["MaHang"].Value.ToString();
                string tenHang = row.Cells["TenHang"].Value.ToString();
                int soLuong = Convert.ToInt32(row.Cells["soluong"].Value);
                float donGiaNhap = Convert.ToSingle(row.Cells["dongianhap"].Value);
                float donGiaBan = Convert.ToSingle(row.Cells["dongiaban"].Value);
                string hinhAnh = row.Cells["hinhanh"].Value.ToString();
                string ghiChu = row.Cells["ghichu"].Value.ToString();

                // Gán dữ liệu vào các TextBox trên Form
                txtCode.Text = maHang;
                txtName.Text = tenHang;
                txtSl.Text = soLuong.ToString();
                txtDonGia.Text = donGiaNhap.ToString();
                txtDonGiaban.Text = donGiaBan.ToString();
                txtHinh.Text = hinhAnh;
                richTextBox1.Text = ghiChu;

                // Hiển thị hình ảnh trong PictureBox (pictureBox1)
                if (!string.IsNullOrEmpty(hinhAnh))
                {
                    pictureBox1.Image = Image.FromFile(hinhAnh);
                }
                else
                {
                    // Nếu không có hình ảnh, bạn có thể hiển thị một hình ảnh mặc định hoặc xử lý theo cách bạn muốn.
                    pictureBox1.Image = null; // Bỏ hình ảnh hiển thị
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string tenHang = txtName.Text;
            int maHang = int.Parse(txtCode.Text);
            int soLuong = int.Parse(txtSl.Text);
            float donGiaNhap = float.Parse(txtDonGia.Text);
            float donGiaBan = float.Parse(txtDonGiaban.Text);
            string hinhAnh = txtHinh.Text;
            string ghiChu = richTextBox1.Text;
            string maNV = frmMain.MaNhanVien;

            // Tạo đối tượng sản phẩm cần sửa
            var productToUpdate = new classSanpham
            {
                TenHang = tenHang,
                MaHang = maHang,
                soluong = soLuong,
                dongianhap = donGiaNhap,
                dongiaban = donGiaBan,
                hinhanh = hinhAnh,
                ghichu = ghiChu,
                MaNV = maNV
            };

            // Gọi hàm sửa sản phẩm từ repository
            sanphamRepository.UpdateProduct(productToUpdate);
            unwrite();
            // Cập nhật DataGridView
            dataGridViewsanpham.DataSource = null;
            dataGridViewsanpham.DataSource = sanphamRepository.GetAllProducts();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            string maHang = txtCode.Text;
            if (maHang == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm với mã hàng này.");
                return;
            }
            // Gọi hàm xóa sản phẩm từ repository
            sanphamRepository.DeleteProduct(maHang);
            unwrite();
            // Cập nhật DataGridView
            dataGridViewsanpham.DataSource = null;
            dataGridViewsanpham.DataSource = sanphamRepository.GetAllProducts();

        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string tenHang = textBox1.Text;

            // Gọi hàm tìm kiếm sản phẩm từ repository
            var searchResults = sanphamRepository.SearchProducts(tenHang);

            // Hiển thị kết quả tìm kiếm trong DataGridView
            dataGridViewsanpham.DataSource = null;
            dataGridViewsanpham.DataSource = searchResults;
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtHinh.Text = Path.GetFileName(openFileDialog.FileName); // Lấy tên tệp
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            unwrite();
        }

        private void unwrite()
        {
            txtName.Enabled = false;
            txtCode.Enabled = false;
            txtDonGia.Enabled = false;
            txtDonGiaban.Enabled = false;
            txtSl.Enabled = false;
            btOpen.Enabled = false;
            btSave.Enabled = false;
            btDel.Enabled = false;
            btEdit.Enabled = false;
        }

        private void btSkip_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewsanpham.CurrentCell.RowIndex;
            if (rowIndex < HangList.Count - 1)
            {
                rowIndex++;
                dataGridViewsanpham.CurrentCell = dataGridViewsanpham.Rows[rowIndex].Cells[0];
            }
        }

        private void btShowList_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*string ten = frmMain.loggedInUser;
            int role = frmMain.userRole;
            string ma = frmMain.MaNhanVien;*/
            FrmMain frmMain1 = new FrmMain(frmMain.loggedInUser, frmMain.userRole, frmMain.MaNhanVien);
            frmMain1.ShowDialog();
        }
    }
}