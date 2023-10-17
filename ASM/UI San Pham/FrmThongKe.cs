using ASM.Core.Context;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class FrmThongKe : Form
    {
        QLBH_Db_Contex context = new QLBH_Db_Contex();
        public FrmThongKe()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            var query = from sanpham in context.SanPhams
                        group sanpham by sanpham.TenHang into g
                        select new
                        {
                            TenHang = g.Key,
                            TongSoLuong = g.Sum(s => s.soluong)
                        };

            // Gán kết quả truy vấn cho DataGridView
            dataGridView2.DataSource = query.ToList();
            var query2 = from sanpham in context.SanPhams
                        join nhanvien in context.NhanViens on sanpham.MaNV equals nhanvien.MaNV
                        group new { sanpham, nhanvien } by new
                        {
                            nhanvien.MaNV,
                            nhanvien.TenNv
                        } into g
                        select new
                        {
                            MaNhanVien = g.Key.MaNV,
                            TenNhanVien = g.Key.TenNv,
                            TongSoLuong = g.Sum(s => s.sanpham.soluong)
                        };

            dataGridView1.DataSource = query2.ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
