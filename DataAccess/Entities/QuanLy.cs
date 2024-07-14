using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class QuanLy
{
    public int MaQl { get; set; }

    public string TenQl { get; set; } = null!;

    public string? Sdt { get; set; }

    public string? DiaChi { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public string? GioiTinh { get; set; }

    public int? MaCv { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ChucVu? MaCvNavigation { get; set; }

    public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; } = new List<PhieuNhap>();

    public virtual ICollection<PhieuXuat> PhieuXuats { get; set; } = new List<PhieuXuat>();

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
