using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class PhieuNhap
{
    public int MaPn { get; set; }

    public DateOnly? NgayNhap { get; set; }

    public int? MaNcc { get; set; }

    public string? Sdtncc { get; set; }

    public int MaSp { get; set; }

    public int? MaCuaHang { get; set; }

    public decimal? TongTienHang { get; set; }

    public int? MaQl { get; set; }

    public virtual CuaHang? MaCuaHangNavigation { get; set; }

    public virtual NhaCungCap? MaNccNavigation { get; set; }

    public virtual QuanLy? MaQlNavigation { get; set; }
}
