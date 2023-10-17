using ASM.Core.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using static Google.Protobuf.Collections.MapField<TKey, TValue>;*/

namespace ASM.UI_Đăng_Nhập.ForgotPass
{
    public partial class FrmForgotwcode : Form
    {
        private string confirmationCode;
        public FrmForgotwcode(string code)
        {
            InitializeComponent();
            confirmationCode = code;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btGui_Click(object sender, EventArgs e)
        {
            /*FrmForgot form1 = new FrmForgot();
            form1.ShowDialog();
            string resetCode = form1.GetResetCode();
            form1.Close();
            if (resetCode != txtCode.Text)
            {
                MessageBox.Show("Mã Đặt Lại Sai Vui Lòng Nhập Lại");
            }
            else
            {
                MessageBox.Show("Đổi Mật Khẩu Thành Công !");
            }*/
            string enteredCode = txtCode.Text;
            if (enteredCode != confirmationCode)
            {
                MessageBox.Show("Mã xác nhận không đúng. Vui lòng kiểm tra lại.");
                return;
            }
            string newPassword = txtNewpass.Text;
            using (QLBH_Db_Contex context = new QLBH_Db_Contex())
            {
                var nhanVien = context.NhanViens.FirstOrDefault(nv => nv.Email == txtEmail.Text);
                if (nhanVien != null)
                {
                    nhanVien.Matkhau = txtNewpass.Text;

                    context.SaveChanges();
                }
            }
        }

        private void FrmForgotwcode_Load(object sender, EventArgs e)
        {

        }
    }
}
