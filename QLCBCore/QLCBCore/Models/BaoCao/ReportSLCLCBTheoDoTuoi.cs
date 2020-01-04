using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models.BaoCao
{
    public class ReportSLCLCBTheoDoTuoi
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenDonVi { get; set; }
        public int? TongSo { get; set; }
        public int? PhuNu { get; set; }
        public int? Nam { get; set; }
        public int? Total20den30 { get; set; }
        public int? Nam20den30 { get; set; }
        public int? Nu20den30 { get; set; }
        public int? Total30den50 { get; set; }
        public int? Nam30den50 { get; set; }
        public int? Nu30den50 { get; set; }
        public int? Totaltren50 { get; set; }
        public int? Namtren50 { get; set; }
        public int? Nutren50 { get; set; }
        public int? STT { get; set; }
        public int? DonViID { get; set; } // DonViID
    }
}
