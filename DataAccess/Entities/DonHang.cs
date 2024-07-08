using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class DonHang
{
    public int MaDh { get; set; }

    public int? MaSp { get; set; }

    public int? MaKh { get; set; }

    public virtual KhachHang? MaKhNavigation { get; set; }

    public virtual SanPham? MaSpNavigation { get; set; }
}
