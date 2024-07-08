using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class HoaDon
{
    public int MaHd { get; set; }

    public DateOnly? NgayBan { get; set; }

    public decimal? TongTien { get; set; }

    public int? MaQl { get; set; }

    public virtual QuanLy? MaQlNavigation { get; set; }
}
