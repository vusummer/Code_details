using ASM.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Core.Services.NewFolder
{
    public interface IKhachHang
    {
        public void AddCustommer(classKhachHang khachhang);
        public void DeleteCustommer(string sodienthoai);
        public void UpdaterCustommer(classKhachHang khachhang);
        public List<classKhachHang> GetAllCustomer();
        public List<classKhachHang> SearchEmployees(string sodienthoai);
    }
}
