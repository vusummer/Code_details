using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Core.Models
{
    public class classKhachHang
    {
        [Key]
        public string DienThoai { get; set; }
        public string? Name { get; set; }
        public string DiaChi { get; set; }
        public byte Phai { get; set; }

        [ForeignKey("NhanVien")]
        public string MaNV { get; set; }
        public classNhanvien NhanVien { get; set; } 
    }
}
