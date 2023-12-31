﻿// <auto-generated />
using ASM.Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASM.Migrations
{
    [DbContext(typeof(QLBH_Db_Contex))]
    partial class QLBH_Db_ContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASM.Core.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("ASM.Core.Models.Khachhang", b =>
                {
                    b.Property<string>("DienThoai")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Phai")
                        .HasColumnType("tinyint");

                    b.HasKey("DienThoai");

                    b.HasIndex("MaNV");

                    b.ToTable("Khachhangs");
                });

            modelBuilder.Entity("ASM.Core.Models.SanPham", b =>
                {
                    b.Property<int>("MaHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHang"));

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("dongiaban")
                        .HasColumnType("real");

                    b.Property<float>("dongianhap")
                        .HasColumnType("real");

                    b.Property<string>("ghichu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hinhanh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("soluong")
                        .HasColumnType("int");

                    b.HasKey("MaHang");

                    b.HasIndex("MaNV");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("ASM.Core.Models.nhanvien", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Matkhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tinhtran")
                        .HasColumnType("int");

                    b.Property<int>("Vaitro")
                        .HasColumnType("int");

                    b.HasKey("MaNV");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("ASM.Core.Models.Khachhang", b =>
                {
                    b.HasOne("ASM.Core.Models.nhanvien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("MaNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("ASM.Core.Models.SanPham", b =>
                {
                    b.HasOne("ASM.Core.Models.nhanvien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("MaNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });
#pragma warning restore 612, 618
        }
    }
}
