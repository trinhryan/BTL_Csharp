using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class SanPham
{
    public int MaSp { get; set; }

    public string? TenSp { get; set; }

    public decimal? GiaSp { get; set; }

    public DateOnly? Hsd { get; set; }

    public DateOnly? Nsx { get; set; }

    public string? PhanLoaiSp { get; set; }

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();
}
