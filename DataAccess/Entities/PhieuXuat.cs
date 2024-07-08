using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class PhieuXuat
{
    public int MaPx { get; set; }

    public DateOnly? NgayXuat { get; set; }

    public int? MaQl { get; set; }

    public virtual QuanLy? MaQlNavigation { get; set; }
}
