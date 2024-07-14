using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class Sale
{
    public int MaSale { get; set; }

    public string TenSale { get; set; } = null!;

    public DateOnly? NgaySinh { get; set; }

    public string GioiTinh { get; set; } = null!;

    public string? Sdt { get; set; }

    public int? MaCuaHang { get; set; }

    public int? Sl { get; set; }

    public int? MaQl { get; set; }

    public string? TenDangNhap { get; set; }

    public string DiaChi { get; set; } = null!;

    public int? MaCv { get; set; }

    public virtual CuaHang? MaCuaHangNavigation { get; set; }

    public virtual ChucVu? MaCvNavigation { get; set; }

    public virtual QuanLy? MaQlNavigation { get; set; }

    public virtual ICollection<PhieuXuat> PhieuXuats { get; set; } = new List<PhieuXuat>();

    public virtual NguoiDung? TenDangNhapNavigation { get; set; }
}
