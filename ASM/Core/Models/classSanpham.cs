using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Core.Models
{
    public class classSanpham
    {
        [Key]
        public int MaHang {  get; set; }
        public string TenHang { get; set; }
        public int soluong { get; set; }
        public float dongiaban { get; set; }
        public float dongianhap { get; set; }
        public string hinhanh { get; set; }
        public string ghichu { get; set; }
        [ForeignKey("NhanVien")]
        public string MaNV { get; set; }
        public classNhanvien NhanVien { get; set; }
    }
}
