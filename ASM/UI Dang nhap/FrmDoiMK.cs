using ASM.Core.Context;
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
    public partial class FrmDoiMK : Form
    {
        public FrmDoiMK()
        {
            InitializeComponent();
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string oldPassword = txtOldPass.Text;
            string newPassword = txtNewpass.Text;
            string confirmPassword = txtNhaplai.Text;

            using (QLBH_Db_Contex context = new QLBH_Db_Contex())
            {
                try
                {
                    var nhanVien = context.NhanViens.FirstOrDefault(nv => nv.Email == email);

                    if (nhanVien == null)
                    {
                        MessageBox.Show("Email nhân viên không tồn tại!");
                        return;
                    }

                    if (nhanVien.Matkhau != oldPassword)
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng. Vui lòng nhập lại!");
                        return;
                    }

                    if (newPassword != confirmPassword)
                    {
                        MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!");
                        return;
                    }

                    // Cập nhật mật khẩu mới và lưu vào cơ sở dữ liệu
                    nhanVien.Matkhau = newPassword;
                    context.SaveChanges();

                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
        }

        private void FrmDoiMK_Load(object sender, EventArgs e)
        {

        }
    }
}
