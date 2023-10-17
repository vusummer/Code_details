using ASM.Core.Context;
using ASM.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM.Core.Services.NhanVien
{
    public class nhanvienRepository : INhanvien
    {
        private readonly QLBH_Db_Contex _context;
        public nhanvienRepository(QLBH_Db_Contex context)
        {
            _context = context;
        }
        public void AddStaff(classNhanvien nhanVien)
        {
            _context.NhanViens.Add(nhanVien);
            _context.SaveChanges();
        }

        public void DeleteStaff(string manv)
        {
            var staffToDelete = _context.NhanViens.FirstOrDefault(nv => nv.MaNV == manv);
            if (staffToDelete != null)
            {
                _context.NhanViens.Remove(staffToDelete);
                _context.SaveChanges();
            }
        }

        public List<classNhanvien> GetAllStaff()
        {
            return _context.NhanViens.ToList();
        }

        

        public List<classNhanvien> SearchStaffs(string tennhanvien)
        {
            return _context.NhanViens.Where(nv => nv.TenNv.Contains(tennhanvien)).ToList();
        }

        public void UpdaterStaff(classNhanvien nhanvien)
        {
            var existingStaff = _context.NhanViens.FirstOrDefault(nv => nv.MaNV == nhanvien.MaNV);
            if (existingStaff != null)
            {
                existingStaff.Email = nhanvien.Email;
                existingStaff.TenNv = nhanvien.TenNv;
                existingStaff.DiaChi = nhanvien.DiaChi;
                existingStaff.Vaitro = nhanvien.Vaitro;
                existingStaff.Tinhtran = nhanvien.Tinhtran;
                existingStaff.Matkhau = nhanvien.Matkhau;

                _context.SaveChanges();
            }
        }
       
    }
}
