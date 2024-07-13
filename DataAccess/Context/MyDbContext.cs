using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataAccess.Migrations;

namespace DataAccess.Context
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CauHoi> CauHois { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost\\sqlserver,1433;Initial Catalog=dev_db;Persist Security Info=True;User ID=sa;Password=trinhnv1205.;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CauHoi>(entity =>
            {
                entity.HasKey(e => e.MaCauHoi)
                    .HasName("PK__cau_hoi__2EB8A2AD5AF1A758");

                entity.ToTable("cau_hoi");

                entity.Property(e => e.MaCauHoi)
                    .ValueGeneratedNever()
                    .HasColumnName("ma_cau_hoi");

                entity.Property(e => e.DapAnA)
                    .HasMaxLength(100)
                    .HasColumnName("dap_an_a");

                entity.Property(e => e.DapAnB)
                    .HasMaxLength(100)
                    .HasColumnName("dap_an_b");

                entity.Property(e => e.DapAnC)
                    .HasMaxLength(100)
                    .HasColumnName("dap_an_c");

                entity.Property(e => e.DapAnD)
                    .HasMaxLength(100)
                    .HasColumnName("dap_an_d");

                entity.Property(e => e.DapAnDung)
                    .HasMaxLength(100)
                    .HasColumnName("dap_an_dung");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(100)
                    .HasColumnName("noi_dung");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.TenDangNhap)
                    .HasName("PK__tai_khoa__363698B27AE7DA03");

                entity.ToTable("tai_khoan");

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ten_dang_nhap");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mat_khau");

                entity.Property(e => e.Quyen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("quyen");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
