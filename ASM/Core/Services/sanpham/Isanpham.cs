using ASM.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Core.Services.sanpham
{
    public interface ISanpham
    {
        void AddProduct(classSanpham sanpham);
        void DeleteProduct(string maHang);
        void UpdateProduct(classSanpham sanPham);
        List<classSanpham> GetAllProducts();
        List<classSanpham> SearchProducts(string tenHang);
    }
}
