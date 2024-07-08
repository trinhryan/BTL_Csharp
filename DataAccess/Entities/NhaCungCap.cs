﻿using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class NhaCungCap
{
    public int MaNcc { get; set; }

    public string? TenNcc { get; set; }

    public string? DiaChi { get; set; }

    public string? Sdt { get; set; }

    public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; } = new List<PhieuNhap>();
}
