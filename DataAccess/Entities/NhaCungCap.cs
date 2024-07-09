using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class NhaCungCap
{
    public int MaNcc { get; set; }

    public string? TenNcc { get; set; }

    public string? DiaChi { get; set; }

    public int? Sdt { get; set; }

    public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; } = new List<PhieuNhap>();

    public void AddData(NhaCungCap nhaCungCap)
    {
        throw new NotImplementedException();
    }
}
