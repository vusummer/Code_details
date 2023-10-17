using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Core.Models
{
    public class classNhanvien
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Key]
        public string MaNV { get; set; }
        public string Email { get; set; }
        public string TenNv { get; set; }
        public string DiaChi { get; set; }
        public int Vaitro { get; set; }
        public int Tinhtran { get; set; }
        public string Matkhau { get; set; }
    }
}
