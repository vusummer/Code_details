using ASM.UI_Đăng_Nhập;
using ASM.UI_Nhân_Viên;

namespace ASM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            /*FrmDangNhap frmDangNhap = new FrmDangNhap();

            if (frmDangNhap.ShowDialog() == DialogResult.OK)
            {
                // Nếu đăng nhập thành công, mở form chính (FrmMain)
                Application.Run(new FrmMain(frmDangNhap.LoggedInUser, frmDangNhap.UserRole));
            }
            else
            {
                // Thoát ứng dụng hoặc thực hiện các xử lý khác khi đăng nhập không thành công
                Application.Exit();
            }*/
            Application.Run(new FrmMain(null, -1, null));
            /*Application.Run(new FrmKhachHang(new FrmMain(null, -1,null)));*/
            /*Application.Run(new FrmSanPham(new FrmMain(null, -1, null)));*/
            /*Application.Run(new FrmThongKe());*/

        }
    }
}