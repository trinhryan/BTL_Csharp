using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class ChucVu
{
    public int MaCv { get; set; }

    public string? TenCv { get; set; }

    public virtual ICollection<QuanLy> QuanLies { get; set; } = new List<QuanLy>();

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
