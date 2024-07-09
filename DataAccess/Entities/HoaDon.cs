using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class HoaDon
{
    public int MaHd { get; set; }
    public int MaSp { get; set; }
    public string TenSp { get; set; }
    
    public int SoLuong { get; set; }
    
    public float DonGia { get; set; }

    public DateOnly? NgayBan { get; set; }
    

    public decimal? TongTien { get; set; }

    public int? MaQl { get; set; }

    public virtual QuanLy? MaQlNavigation { get; set; }
    public virtual SanPham? MaSpNavigation { get; set; }
}
