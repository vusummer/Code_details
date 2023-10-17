using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using ASM.UI_Đăng_Nhập.ForgotPass;

namespace ASM.UI_Đăng_Nhập
{
    public partial class FrmForgot : Form
    {
        private string resetCode;
        public FrmForgot()
        {
            InitializeComponent();
        }

        private void btGui_Click(object sender, EventArgs e)
        {
                string emailOrUsername = txtEmail.Text;

            // Tạo đối tượng MailMessage
            MailMessage mail = new MailMessage();

            // Địa chỉ email của người gửi
            mail.From = new MailAddress("vuntpk02984@fpt.edu.vn");

            // Địa chỉ email của người nhận (có thể là địa chỉ người dùng nhập vào TextBox)
            mail.To.Add(emailOrUsername);

            // Tiêu đề email
            mail.Subject = "Yêu Cầu Đặt Lại Mật Khẩu";

            // Nội dung email (có thể là mã đặt lại mật khẩu hoặc liên kết đặt lại mật khẩu)
            resetCode = GenerateRandomCode(6);
            mail.Body = "Mã đặt lại mật khẩu của bạn là: " + resetCode;

            // Cấu hình SmtpClient
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            string app_password = "bczy donf obeq cugt";
            smtp.Credentials = new NetworkCredential("vuntpk02984@fpt.edu.vn", app_password);
            smtp.EnableSsl = true;
            

            try
            {
                // Gửi email
                smtp.Send(mail);
                MessageBox.Show("Yêu cầu đặt lại mật khẩu đã được gửi đến địa chỉ email của bạn.");
                FrmForgotwcode frmForgotwcode = new FrmForgotwcode(resetCode);
                frmForgotwcode.ShowDialog();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu gửi email không thành công
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        public string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string code = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return code;
        }
        public string GetResetCode()
        {
            return resetCode;
        }
    }
}
