using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class CuaHang
{
    public int MaCuaHang { get; set; }

    public string TenCuaHang { get; set; } = null!;

    public string? DiaChi { get; set; }

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();

    public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; } = new List<PhieuNhap>();

    public virtual ICollection<PhieuXuat> PhieuXuats { get; set; } = new List<PhieuXuat>();

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
