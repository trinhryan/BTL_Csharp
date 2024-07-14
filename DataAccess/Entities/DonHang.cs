using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class DonHang
{
    public int MaDh { get; set; }

    public int? MaSp { get; set; }

    public int? MaKh { get; set; }

    public int? MaCuaHang { get; set; }

    public DateOnly? NgayTao { get; set; }

    public decimal? TongTien { get; set; }

    public string TrangThai { get; set; } = null!;

    public virtual CuaHang? MaCuaHangNavigation { get; set; }

    public virtual KhachHang? MaKhNavigation { get; set; }

    public virtual SanPham? MaSpNavigation { get; set; }
}
