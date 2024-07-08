using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class CuaHang
{
    public int MaCuaHang { get; set; }

    public string? TenCuaHang { get; set; }

    public string? DiaChi { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
