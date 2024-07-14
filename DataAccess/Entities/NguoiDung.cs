using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class NguoiDung
{
    public string TenDangNhap { get; set; } = null!;

    public string? HoTen { get; set; }

    public string? MatKhau { get; set; }

    public string? GioiTinh { get; set; }

    public string? Sdt { get; set; }

    public string? DiaChi { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
