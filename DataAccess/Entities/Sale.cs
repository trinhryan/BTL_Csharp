using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class Sale
{
    public int MaSale { get; set; }

    public string? TenSale { get; set; }

    public DateOnly? NgaySinh { get; set; }
    
    public string GioiTinh { get; set; }

    public string? Sdt { get; set; }

    public int? ChucVu { get; set; }

    public int? MaCuaHang { get; set; }

    public int? Sl { get; set; }

    public int? MaQl { get; set; }

    public string? TenDangNhap { get; set; }

    public virtual ChucVu? ChucVuNavigation { get; set; }

    public virtual CuaHang? CuaHangNavigation { get; set; }

    public virtual QuanLy? MaQlNavigation { get; set; }

    public virtual NguoiDung? TenDangNhapNavigation { get; set; }
}
