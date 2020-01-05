using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models.ThongKe
{
    public class ThongKeTheoTonGiao
    {
        public int? ID { get; set; }
        public string TenDonVi { get; set; }
        public int? Leve { get; set; }
        public string MaCha { get; set; }
        public string KieuDonVi { get; set; }
        public int? STT { get; set; }
        public int? TongSo { get; set; }
        public int? CoTonGiao { get; set; }
        public int? KhongTonGiao { get; set; }
    }
}
