using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class ChiTietDonHang
{
    public int? MaDh { get; set; }

    public DateOnly? NgayTao { get; set; }

    public int? CuaHang { get; set; }

    public int? MaKh { get; set; }

    public string? TenKh { get; set; }

    public string? Sdt { get; set; }

    public int? MaSp { get; set; }

    public string? TenSp { get; set; }

    public int? SoLuongSp { get; set; }

    public decimal? TongGiaTien { get; set; }

    public virtual CuaHang? CuaHangNavigation { get; set; }

    public virtual DonHang? MaDhNavigation { get; set; }

    public virtual KhachHang? MaKhNavigation { get; set; }

    public virtual SanPham? MaSpNavigation { get; set; }
}
