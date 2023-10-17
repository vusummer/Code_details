using ASM.Core.Models;
using ASM.Core.Services.NhanVien;
using ASM.UI_Nhân_Viên;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ASM.UI_Đăng_Nhập
{

    public partial class FrmMain : Form
    {
        public string MaNhanVien { get; private set; }
        public string loggedInUser { get; private set; }
        public int userRole { get; private set; }


        public FrmMain(string username, int role, string maNhanVien)
        {
            InitializeComponent();
            loggedInUser = username;
            userRole = role;
            UpdateMenuItems();
            MaNhanVien = maNhanVien;

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private void UpdateMenuItems()
        {
            if (loggedInUser == null)
            {
                menuStripRole.Visible = false;
            }
            else
            {
                menuStripnull.Visible = false;
                if (menuStripRole != null)
                {
                    if (userRole == 0) // Ví dụ: Quyền của nhân viên
                    {
                        Label label = new Label();
                        label.Text = loggedInUser;

                        ToolStripControlHost host = new ToolStripControlHost(label);
                        tooltripHoso.Visible = false;
                        tooltripNhanvien.Visible = false;

                    }
                    else if (userRole == 1) // Ví dụ: Quyền của admin
                    {
                        // Hiện chức năng cho admin
                        // Kiểm tra xem menuStripRole.Items["tooltripHoso"] đã được khởi tạo chưa
                        if (menuStripRole.Items.ContainsKey("tooltripHoso"))
                        {
                            menuStripRole.Items["tooltripHoso"].Visible = true;
                        }

                        // Kiểm tra xem menuStripRole.Items["tooltripNhanvien"] đã được khởi tạo chưa
                        if (menuStripRole.Items.ContainsKey("tooltripNhanvien"))
                        {
                            menuStripRole.Items["tooltripNhanvien"].Visible = true;
                        }
                    }
                }
            }
        }

        private void tooltripDangxuat_Click(object sender, EventArgs e)
        {
            loggedInUser = "";
            userRole = -1;
            // Tải lại Form chính sau khi đăng xuất
            this.Close(); // Đóng Form chính
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.ShowDialog(); // Mở Form đăng nhập
        }

        private void tooltripthoat_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo hỏi người dùng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                FrmNhanVien frmNhanVien = new FrmNhanVien(this);
                frmNhanVien.ShowDialog();
            }
        }

        private void tooltripHoso_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmNhanVien frmNhanVien = new FrmNhanVien(new FrmMain(loggedInUser, userRole, MaNhanVien));
            frmNhanVien.ShowDialog();
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tooltripSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSanPham frmDangNhap = new FrmSanPham(new FrmMain(loggedInUser, userRole, MaNhanVien));
            frmDangNhap.ShowDialog();
        }

        private void tooltripKhachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKhachHang frmDangNhap = new FrmKhachHang(new FrmMain(loggedInUser, userRole, MaNhanVien));
            frmDangNhap.ShowDialog();
        }

        private void tooltripSPnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmThongKe frmThongKe = new FrmThongKe();
            frmThongKe.ShowDialog();
        }

        private void tooltripNhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNhanVien frmNhanVien = new FrmNhanVien(this);
            frmNhanVien.ShowDialog();
        }
    }
}