using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models.ThongKe
{
    public class ThongKeHocHam
    {
        public int? ID { get; set; }
        public string TenDonVi { get; set; }
        public int? TongSo { get; set; }
        public int? GiaoSu { get; set; }
        public int? PhoGiaoSu { get; set; }
        public int? Khac { get; set; }
    }
}
