using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using ASM.Core.Context;
using ASM.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Configuration;
using Newtonsoft.Json;
using System.Threading.Tasks.Sources;
using BCrypt.Net;
using ASM.Core.Services.NhanVien;

namespace ASM.UI_Đăng_Nhập
{
    public partial class FrmDangNhap : Form
    {
        public string LoggedInUser { get; private set; }
        public int UserRole { get; private set; }
        public string MaNV { get; private set; }
        public class AppSettings
        {
            public bool RememberPassword { get; set; }
            public string SavedUsername { get; set; }
            public string SavedPassword { get; set; }
        }
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        private void AddSampleAdminAccount()
        {
            using (QLBH_Db_Contex context = new QLBH_Db_Contex())
            {
                // Kiểm tra xem đã có tài khoản admin mẫu trong cơ sở dữ liệu hay chưa
                var existingAdmin = context.NhanViens.FirstOrDefault(nv => nv.Vaitro == 1);

                if (existingAdmin == null)
                {
                    // Tạo một tài khoản admin mẫu
                    var adminAccount = new classNhanvien
                    {
                        MaNV = "NVAdmin", // Đặt mã nhân viên admin mẫu
                        Email = "admin",
                        Matkhau = "admin", // Đặt mật khẩu admin mẫu
                        Vaitro = 1, // 1 là admin, 0 là nhân viên
                    };

                    // Thêm tài khoản admin mẫu vào cơ sở dữ liệu
                    context.NhanViens.Add(adminAccount);
                    context.SaveChanges();
                }
            }
        }
        private void btGui_Click(object sender, EventArgs e)
        {
            /*
                if (nhanVien != null && PasswordHasher.VerifyPassword(password, nhanVien.Matkhau))
                {
                    LoggedInUser = username;
                    UserRole = nhanVien.Vaitro;
                    MaNV = nhanVien.MaNV;

                    if (radioButton1.Checked)
                    {
                        // Lưu mật khẩu và tên người dùng vào tệp JSON
                        var appSettings = new AppSettings
                        {
                            RememberPassword = true,
                            SavedUsername = username,
                            SavedPassword = password
                        };

                        string json = JsonConvert.SerializeObject(appSettings);

                        // Lưu thay đổi vào tệp appsettings.json
                        File.WriteAllText("appsettings.json", json);
                    }
                  }*/
            AddSampleAdminAccount();
            string username = txtEmail.Text;
            string password = txtPass.Text;

            using (QLBH_Db_Contex context = new QLBH_Db_Contex())
            {
                var nhanVien = context.NhanViens.FirstOrDefault(nv => nv.Email == username);

                if (nhanVien != null && nhanVien.Matkhau == password)
                {
                    LoggedInUser = username;
                    UserRole = nhanVien.Vaitro;
                    MaNV = nhanVien.MaNV;
                    // Kiểm tra xem RadioButton 1 đã được chọn hay không
                    if (radioButton1.Checked)
                    {
                        // Lưu mật khẩu và tên người dùng vào tệp JSON
                        var appSettings = new
                        {
                            RememberPassword = true,
                            SavedUsername = username,
                            SavedPassword = password
                        };

                        string json = JsonConvert.SerializeObject(appSettings);

                        // Lưu thay đổi vào tệp appsettings.json
                        File.WriteAllText("appsettings.json", json);
                    }

                    MessageBox.Show($"Đăng nhập thành công với vai trò: {(UserRole == 0 ? "Nhân viên" : "Admin")}");
                    FrmMain frmMain = new FrmMain(LoggedInUser, UserRole, MaNV);
                    this.Hide();
                    frmMain.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại email và mật khẩu.");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmForgot frmForgot = new FrmForgot();
            frmForgot.ShowDialog();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            ReadAppSettings();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private AppSettings ReadAppSettingsFromJson(string json)
        {
            try
            {
                AppSettings appSettings = JsonConvert.DeserializeObject<AppSettings>(json);
                return appSettings;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show($"Đã xảy ra lỗi khi đọc dữ liệu cấu hình: {ex.Message}");
                return null;
            }
        }

        // Sử dụng hàm ReadAppSettingsFromJson để đọc cấu hình từ chuỗi JSON
        private void ReadAppSettings()
        {
            string json = File.ReadAllText("appsettings.json");
            AppSettings appSettings = ReadAppSettingsFromJson(json);

            if (appSettings != null)
            {
                // Sử dụng dữ liệu cấu hình
                if (appSettings.RememberPassword)
                {
                    string savedUsername = appSettings.SavedUsername;
                    string savedPassword = appSettings.SavedPassword;
                    txtEmail.Text = savedUsername;
                    txtPass.Text = savedPassword;
                }
                else
                {
                    txtEmail.Text = "";
                    txtPass.Text = "";
                }
            }
        }
    }
}