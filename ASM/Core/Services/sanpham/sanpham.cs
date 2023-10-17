using ASM.Core.Context;
using ASM.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM.Core.Services.sanpham
{
    public class sanphamRepository : ISanpham
    {
        private readonly QLBH_Db_Contex _context;

        public sanphamRepository(QLBH_Db_Contex context)
        {
            _context = context;
        }

        public void AddProduct(classSanpham sanpham)
        {
            _context.SanPhams.Add(sanpham);
            _context.SaveChanges();
        }

        public void DeleteProduct(string maHang)
        {
            var productToDelete = _context.SanPhams.Find(maHang);
            if (productToDelete != null)
            {
                _context.SanPhams.Remove(productToDelete);
                _context.SaveChanges();
            }
        }

        public List<classSanpham> GetAllProducts()
        {
            return _context.SanPhams.ToList();
        }
        public List<classSanpham> SearchProducts(string tenHang)
        {
            return _context.SanPhams.Where(sp => sp.TenHang.Contains(tenHang)).ToList();
        }

        public void UpdateProduct(classSanpham sanPham)
        {
            var existingProduct = _context.SanPhams.Find(sanPham.MaHang);
            if (existingProduct != null)
            {
                existingProduct.TenHang = sanPham.TenHang;
                existingProduct.soluong = sanPham.soluong;
                existingProduct.dongiaban = sanPham.dongiaban;
                existingProduct.dongianhap = sanPham.dongianhap;
                existingProduct.hinhanh = sanPham.hinhanh;
                existingProduct.ghichu = sanPham.ghichu;
                existingProduct.MaNV = sanPham.MaNV;

                _context.SaveChanges();
            }
        }
    }
}
