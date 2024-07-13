using System;
using System.Collections.Generic;

namespace DataAccess.Migrations
{
    public partial class CauHoi
    {
        public int MaCauHoi { get; set; }
        public string? NoiDung { get; set; }
        public string? DapAnA { get; set; }
        public string? DapAnB { get; set; }
        public string? DapAnC { get; set; }
        public string? DapAnD { get; set; }
        public string? DapAnDung { get; set; }
    }
}
