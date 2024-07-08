using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class PhieuNhap
{
    public int? MaSP;
    public int? MaNcc;
    public int MaPn { get; set; }
    public int MaCuaHang { get; set; }
    public DateOnly? NgayNhap { get; set; }
    public decimal? TongTienHang { get; set; }

    public int? MaQl { get; set; }
    public float? DonGia { get; set; }
    public int? SoLuong { get; set; }
    public string? TenSanPham { get; set; }
    public string? SoDienThoai { get; set; }
    public virtual NhaCungCap? MaNccNavigation { get; set; }
    public virtual QuanLy? MaQlNavigation { get; set; }
    public virtual CuaHang? MaCHNNavigation { get; set; }
}