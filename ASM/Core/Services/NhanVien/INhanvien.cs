using ASM.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Core.Services.NhanVien
{
    public interface INhanvien
    {
        void AddStaff(classNhanvien nhanVien);
         void DeleteStaff(string manv);
         void UpdaterStaff(classNhanvien nhanvien);
         List<classNhanvien> GetAllStaff();
         List<classNhanvien> SearchStaffs(string tennhanvien);
        
    }
}
