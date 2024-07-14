using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class PhieuXuat
{
    public int MaPx { get; set; }

    public int MaCuaHang { get; set; }

    public DateOnly? NgayXuat { get; set; }

    public int? MaQl { get; set; }

    public string TenSp { get; set; } = null!;

    public int? MaSale { get; set; }

    public virtual CuaHang MaCuaHangNavigation { get; set; } = null!;

    public virtual QuanLy? MaQlNavigation { get; set; }

    public virtual Sale? MaSaleNavigation { get; set; }
}
