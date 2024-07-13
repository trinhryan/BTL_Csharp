using System;
using System.Collections.Generic;

namespace DataAccess.Migrations
{
    public partial class TaiKhoan
    {
        public string TenDangNhap { get; set; } = null!;
        public string? MatKhau { get; set; }
        public string? Quyen { get; set; }
    }
}
