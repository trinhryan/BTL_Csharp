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
        => optionsBuilder.UseSqlServer("Data Source=localhost\\sqlserver,1433;Initial Catalog=dev_db;Persist Security Info=True;User ID=sa;Password=trinhnv1205.;TrustServerCertificate=True");

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
                .HasColumnName("TenKH");
            entity.Property(e => e.TenSp)
                .HasMaxLength(100)
                .HasColumnName("TenSP");
            entity.Property(e => e.TongGiaTien).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.CuaHangNavigation).WithMany()
                .HasForeignKey(d => d.CuaHang)
                .HasConstraintName("FK__ChiTietDo__CuaHa__18EBB532");

            entity.HasOne(d => d.MaDhNavigation).WithMany()
                .HasForeignKey(d => d.MaDh)
                .HasConstraintName("FK__ChiTietDon__MaDH__17F790F9");

            entity.HasOne(d => d.MaKhNavigation).WithMany()
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK__ChiTietDon__MaKH__19DFD96B");

            entity.HasOne(d => d.MaSpNavigation).WithMany()
                .HasForeignKey(d => d.MaSp)
                .HasConstraintName("FK__ChiTietDon__MaSP__1AD3FDA4");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.MaCv).HasName("PK__ChucVu__27258E76B5DAE038");

            entity.ToTable("ChucVu");

            entity.Property(e => e.MaCv).HasColumnName("MaCV");
            entity.Property(e => e.TenCv)
                .HasMaxLength(100)
                .HasColumnName("TenCV");
        });

        modelBuilder.Entity<CuaHang>(entity =>
        {
            entity.HasKey(e => e.MaCuaHang).HasName("PK__CuaHang__0840BCA6850A5D5D");

            entity.ToTable("CuaHang");

            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.TenCuaHang).HasMaxLength(100);
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasKey(e => e.MaDh).HasName("PK__DonHang__272586610FE3832F");

            entity.ToTable("DonHang");

            entity.Property(e => e.MaDh).HasColumnName("MaDH");
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.MaSp).HasColumnName("MaSP");
            entity.Property(e => e.TongTien).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(50)
                .HasDefaultValue("");

            entity.HasOne(d => d.MaCuaHangNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaCuaHang)
                .HasConstraintName("FK__DonHang__MaCuaHa__151B244E");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK__DonHang__MaKH__14270015");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaSp)
                .HasConstraintName("FK__DonHang__MaSP__1332DBDC");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E0CA388C27");

            entity.ToTable("HoaDon");

            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.DonGia).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MaQl).HasColumnName("MaQL");
            entity.Property(e => e.MaSp).HasColumnName("MaSP");
            entity.Property(e => e.TenSp)
                .HasMaxLength(100)
                .HasColumnName("TenSP");
            entity.Property(e => e.TongTien).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.MaQlNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaQl)
                .HasConstraintName("FK__HoaDon__MaQL__1DB06A4F");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1EA8F19A34");

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenKh)
                .HasMaxLength(100)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.TenDangNhap).HasName("PK__NguoiDun__55F68FC1522C7EF3");

            entity.ToTable("NguoiDung");

            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HoTen).HasMaxLength(100);
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
            entity.HasKey(e => e.MaNcc).HasName("PK__NhaCungC__3A185DEB1FD35355");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.MaNcc).HasColumnName("MaNCC");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenNcc)
                .HasMaxLength(100)
                .HasColumnName("TenNCC");
        });

        modelBuilder.Entity<PhieuNhap>(entity =>
        {
            entity.HasKey(e => e.MaPn).HasName("PK__PhieuNha__2725E7F03D007FF8");

            entity.ToTable("PhieuNhap");

            entity.Property(e => e.MaPn).HasColumnName("MaPN");
            entity.Property(e => e.MaNcc).HasColumnName("MaNCC");
            entity.Property(e => e.MaQl).HasColumnName("MaQL");
            entity.Property(e => e.MaSp).HasColumnName("MaSP");
            entity.Property(e => e.Sdtncc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDTNCC");
            entity.Property(e => e.TongTienHang).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.MaCuaHangNavigation).WithMany(p => p.PhieuNhaps)
                .HasForeignKey(d => d.MaCuaHang)
                .HasConstraintName("FK__PhieuNhap__MaCua__2180FB33");

            entity.HasOne(d => d.MaNccNavigation).WithMany(p => p.PhieuNhaps)
                .HasForeignKey(d => d.MaNcc)
                .HasConstraintName("FK__PhieuNhap__MaNCC__208CD6FA");

            entity.HasOne(d => d.MaQlNavigation).WithMany(p => p.PhieuNhaps)
                .HasForeignKey(d => d.MaQl)
                .HasConstraintName("FK__PhieuNhap__MaQL__22751F6C");
        });

        modelBuilder.Entity<PhieuXuat>(entity =>
        {
            entity.HasKey(e => e.MaPx).HasName("PK__PhieuXua__2725E7CA8F59D0BB");

            entity.ToTable("PhieuXuat");

            entity.Property(e => e.MaPx).HasColumnName("MaPX");
            entity.Property(e => e.MaQl).HasColumnName("MaQL");
            entity.Property(e => e.TenSp)
                .HasMaxLength(100)
                .HasColumnName("TenSP");

            entity.HasOne(d => d.MaCuaHangNavigation).WithMany(p => p.PhieuXuats)
                .HasForeignKey(d => d.MaCuaHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PhieuXuat__MaCua__25518C17");

            entity.HasOne(d => d.MaQlNavigation).WithMany(p => p.PhieuXuats)
                .HasForeignKey(d => d.MaQl)
                .HasConstraintName("FK__PhieuXuat__MaQL__2645B050");

            entity.HasOne(d => d.MaSaleNavigation).WithMany(p => p.PhieuXuats)
                .HasForeignKey(d => d.MaSale)
                .HasConstraintName("FK__PhieuXuat__MaSal__2739D489");
        });

        modelBuilder.Entity<QuanLy>(entity =>
        {
            entity.HasKey(e => e.MaQl).HasName("PK__QuanLy__2725F852577F6678");

            entity.ToTable("QuanLy");

            entity.Property(e => e.MaQl).HasColumnName("MaQL");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
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
                .HasColumnName("TenQL");

            entity.HasOne(d => d.MaCvNavigation).WithMany(p => p.QuanLies)
                .HasForeignKey(d => d.MaCv)
                .HasConstraintName("FK__QuanLy__MaCV__05D8E0BE");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.MaSale).HasName("PK__Sale__B234B7A752B35977");

            entity.ToTable("Sale");

            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaCv).HasColumnName("MaCV");
            entity.Property(e => e.MaQl).HasColumnName("MaQL");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenSale).HasMaxLength(100);

            entity.HasOne(d => d.MaCuaHangNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.MaCuaHang)
                .HasConstraintName("FK__Sale__MaCuaHang__08B54D69");

            entity.HasOne(d => d.MaCvNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.MaCv)
                .HasConstraintName("FK__Sale__MaCV__0C85DE4D");

            entity.HasOne(d => d.MaQlNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.MaQl)
                .HasConstraintName("FK__Sale__MaQL__09A971A2");

            entity.HasOne(d => d.TenDangNhapNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.TenDangNhap)
                .HasConstraintName("FK__Sale__TenDangNha__0A9D95DB");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081C47A1B279");

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSp).HasColumnName("MaSP");
            entity.Property(e => e.GiaSp)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GiaSP");
            entity.Property(e => e.Hsd).HasColumnName("HSD");
            entity.Property(e => e.Nsx).HasColumnName("NSX");
            entity.Property(e => e.PhanLoaiSp)
                .HasMaxLength(100)
                .HasColumnName("PhanLoaiSP");
            entity.Property(e => e.TenSp)
                .HasMaxLength(100)
                .HasColumnName("TenSP");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
