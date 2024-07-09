using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class PhieuXuat
{
    public int MaNV;
    public int MaSP;
    public int MaPx { get; set; }
    public int MaCuaHang { get; set; }
    public DateOnly? NgayXuat { get; set; }

    public int? MaQl { get; set; }
    
    public string TenSP { get; set; }

    public virtual QuanLy? MaQlNavigation { get; set; }
    public virtual Sale? MaNVNavigation { get; set; }
    public virtual SanPham? MaSPNavigation { get; set; }
    public virtual CuaHang? MaCuaHangNavigation { get; set; }
    
}
