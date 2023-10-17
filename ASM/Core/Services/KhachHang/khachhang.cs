using ASM.Core.Context;
using ASM.Core.Models;
using ASM.Core.Services.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM.Core.Services.KhachHang
{
    public class khachhangRepository : IKhachHang
    {
        private readonly QLBH_Db_Contex _context;

        public khachhangRepository(QLBH_Db_Contex context)
        {
            _context = context;
        }
        public void AddCustommer(classKhachHang khachhang)
        {
            _context.Khachhangs.Add(khachhang);
            _context.SaveChanges();
        }

        public void DeleteCustommer(string sodienthoai)
        {
            var customerToDelete = _context.Khachhangs.FirstOrDefault(c => c.DienThoai == sodienthoai);
            if (customerToDelete != null)
            {
                _context.Khachhangs.Remove(customerToDelete);
                _context.SaveChanges();
            }
        }

        public List<classKhachHang> GetAllCustomer()
        {
            return _context.Khachhangs.ToList();
        }

        public List<classKhachHang> SearchEmployees(string sodienthoai)
        {
            return _context.Khachhangs.Where(c => c.DienThoai.Contains(sodienthoai)).ToList();
        }

        public void UpdaterCustommer(classKhachHang khachhang)
        {
            var existingCustomer = _context.Khachhangs.FirstOrDefault(c => c.DienThoai == khachhang.DienThoai);
            if (existingCustomer != null)
            {
                existingCustomer.Name = khachhang.Name;
                existingCustomer.DiaChi = khachhang.DiaChi;
                existingCustomer.Phai = khachhang.Phai;
                existingCustomer.MaNV = khachhang.MaNV;

                _context.SaveChanges();
            }
        }
    }
}
