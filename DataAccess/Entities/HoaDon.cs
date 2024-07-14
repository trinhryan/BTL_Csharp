using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class HoaDon
{
    public int MaHd { get; set; }

    public int MaSp { get; set; }

    public string TenSp { get; set; } = null!;

    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public DateOnly? NgayBan { get; set; }

    public decimal? TongTien { get; set; }

    public int? MaQl { get; set; }

    public virtual QuanLy? MaQlNavigation { get; set; }
}
