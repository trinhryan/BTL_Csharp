using System;
using System.Collections.Generic;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<CuaHang> CuaHangs { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }

    public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }

    public virtual DbSet<QuanLy> QuanLies { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-LJOB371P\\SQLEXPRESS01;Initial Catalog=DATABASE_QL_Ban_Hang;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChiTietDonHang");

            entity.Property(e => e.MaDh).HasColumnName("MaDH");
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.MaSp).HasColumnName("MaSP");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.SoLuongSp).HasColumnName("SoLuongSP");
            entity.Property(e => e.TenKh)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TenKH");
            entity.Property(e => e.TenSp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TenSP");
            entity.Property(e => e.TongGiaTien).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.CuaHangNavigation).WithMany()
                .HasForeignKey(d => d.CuaHang)
                .HasConstraintName("FK__ChiTietDo__CuaHa__5FB337D6");

            entity.HasOne(d => d.MaDhNavigation).WithMany()
                .HasForeignKey(d => d.MaDh)
                .HasConstraintName("FK__ChiTietDon__MaDH__5EBF139D");

            entity.HasOne(d => d.MaKhNavigation).WithMany()
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK__ChiTietDon__MaKH__60A75C0F");

            entity.HasOne(d => d.MaSpNavigation).WithMany()
                .HasForeignKey(d => d.MaSp)
                .HasConstraintName("FK__ChiTietDon__MaSP__619B8048");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.MaCv).HasName("PK__ChucVu__27258E76CB839769");

            entity.ToTable("ChucVu");

            entity.Property(e => e.MaCv)
                .ValueGeneratedNever()
                .HasColumnName("MaCV");
            entity.Property(e => e.TenCv)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TenCV");
        });

        modelBuilder.Entity<CuaHang>(entity =>
        {
            entity.HasKey(e => e.MaCuaHang).HasName("PK__CuaHang__0840BCA6C880D736");

            entity.ToTable("CuaHang");

            entity.Property(e => e.MaCuaHang).ValueGeneratedNever();
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TenCuaHang)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasKey(e => e.MaDh).HasName("PK__DonHang__27258661E9C30AA0");

            entity.ToTable("DonHang");

            entity.Property(e => e.MaDh)
                .ValueGeneratedNever()
                .HasColumnName("MaDH");
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.MaSp).HasColumnName("MaSP");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK__DonHang__MaKH__5CD6CB2B");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaSp)
                .HasConstraintName("FK__DonHang__MaSP__5BE2A6F2");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E008FED14D");

            entity.ToTable("HoaDon");

            entity.Property(e => e.MaHd)
                .ValueGeneratedNever()
                .HasColumnName("MaHD");
            entity.Property(e => e.MaQl).HasColumnName("MaQL");
            entity.Property(e => e.TongTien).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.MaQlNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaQl)
                .HasConstraintName("FK__HoaDon__MaQL__6477ECF3");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1E9E12D26C");

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKh)
                .ValueGeneratedNever()
                .HasColumnName("MaKH");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenKh)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.TenDangNhap).HasName("PK__NguoiDun__55F68FC1745B5175");

            entity.ToTable("NguoiDung");

            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HoTen)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNcc).HasName("PK__NhaCungC__3A185DEB39898FA7");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.MaNcc)
                .ValueGeneratedNever()
                .HasColumnName("MaNCC");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TenNcc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TenNCC");
        });

        modelBuilder.Entity<PhieuNhap>(entity =>
        {
            entity.HasKey(e => e.MaPn).HasName("PK__PhieuNha__2725E7F0A1544A75");

            entity.ToTable("PhieuNhap");

            entity.Property(e => e.MaPn)
                .ValueGeneratedNever()
                .HasColumnName("MaPN");
            entity.Property(e => e.MaNcc).HasColumnName("MaNCC");
            entity.Property(e => e.MaQl).HasColumnName("MaQL");
            entity.Property(e => e.TongTienHang).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.MaNccNavigation).WithMany(p => p.PhieuNhaps)
                .HasForeignKey(d => d.MaNcc)
                .HasConstraintName("FK__PhieuNhap__MaNCC__693CA210");

            entity.HasOne(d => d.MaQlNavigation).WithMany(p => p.PhieuNhaps)
                .HasForeignKey(d => d.MaQl)
                .HasConstraintName("FK__PhieuNhap__MaQL__6A30C649");
        });

        modelBuilder.Entity<PhieuXuat>(entity =>
        {
            entity.HasKey(e => e.MaPx).HasName("PK__PhieuXua__2725E7CA7610C990");

            entity.ToTable("PhieuXuat");

            entity.Property(e => e.MaPx)
                .ValueGeneratedNever()
                .HasColumnName("MaPX");
            entity.Property(e => e.MaQl).HasColumnName("MaQL");

            entity.HasOne(d => d.MaQlNavigation).WithMany(p => p.PhieuXuats)
                .HasForeignKey(d => d.MaQl)
                .HasConstraintName("FK__PhieuXuat__MaQL__6D0D32F4");
        });

        modelBuilder.Entity<QuanLy>(entity =>
        {
            entity.HasKey(e => e.MaQl).HasName("PK__QuanLy__2725F8529CFD4029");

            entity.ToTable("QuanLy");

            entity.Property(e => e.MaQl)
                .ValueGeneratedNever()
                .HasColumnName("MaQL");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaCv).HasColumnName("MaCV");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenQl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TenQL");

            entity.HasOne(d => d.MaCvNavigation).WithMany(p => p.QuanLies)
                .HasForeignKey(d => d.MaCv)
                .HasConstraintName("FK__QuanLy__MaCV__4F7CD00D");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.MaSale).HasName("PK__Sale__B234B7A748EE0427");

            entity.ToTable("Sale");

            entity.Property(e => e.MaSale).ValueGeneratedNever();
            entity.Property(e => e.MaQl).HasColumnName("MaQL");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenSale)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.ChucVuNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.ChucVu)
                .HasConstraintName("FK__Sale__ChucVu__52593CB8");

            entity.HasOne(d => d.CuaHangNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.CuaHang)
                .HasConstraintName("FK__Sale__CuaHang__534D60F1");

            entity.HasOne(d => d.MaQlNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.MaQl)
                .HasConstraintName("FK__Sale__MaQL__5441852A");

            entity.HasOne(d => d.TenDangNhapNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.TenDangNhap)
                .HasConstraintName("FK__Sale__TenDangNha__5535A963");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081C391B8501");

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSp)
                .ValueGeneratedNever()
                .HasColumnName("MaSP");
            entity.Property(e => e.GiaSp)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GiaSP");
            entity.Property(e => e.Hsd).HasColumnName("HSD");
            entity.Property(e => e.Nsx).HasColumnName("NSX");
            entity.Property(e => e.PhanLoaiSp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PhanLoaiSP");
            entity.Property(e => e.TenSp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TenSP");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
