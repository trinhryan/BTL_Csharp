﻿// <auto-generated />
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Entities
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240714080337_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataAccess.Migrations.CauHoi", b =>
                {
                    b.Property<int>("MaCauHoi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_cau_hoi");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCauHoi"), 1L, 1);

                    b.Property<string>("DapAnA")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("dap_an_a");

                    b.Property<string>("DapAnB")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("dap_an_b");

                    b.Property<string>("DapAnC")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("dap_an_c");

                    b.Property<string>("DapAnD")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("dap_an_d");

                    b.Property<string>("DapAnDung")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("dap_an_dung");

                    b.Property<string>("NoiDung")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("noi_dung");

                    b.HasKey("MaCauHoi")
                        .HasName("PK__cau_hoi__2EB8A2ADAFA085C1");

                    b.ToTable("cau_hoi", (string)null);
                });

            modelBuilder.Entity("DataAccess.Migrations.TaiKhoan", b =>
                {
                    b.Property<string>("TenDangNhap")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("ten_dang_nhap");

                    b.Property<string>("MatKhau")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("mat_khau");

                    b.Property<string>("Quyen")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("quyen");

                    b.HasKey("TenDangNhap")
                        .HasName("PK__tai_khoa__363698B26A940221");

                    b.ToTable("tai_khoan", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
