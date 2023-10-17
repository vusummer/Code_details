using ASM.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Core.Context
{
    public class QLBH_Db_Contex : DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<classKhachHang> Khachhangs { get; set; }
        public DbSet<classNhanvien> NhanViens { get; set; }
        public DbSet<classSanpham> SanPhams { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //nhớ ghi cái tên ở catalog vào thăng đần===================Catalog=Students==
            optionsBuilder.UseSqlServer("Data Source=SUMMERTIME;Initial Catalog=DuAnThietKe;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }
    }
}
