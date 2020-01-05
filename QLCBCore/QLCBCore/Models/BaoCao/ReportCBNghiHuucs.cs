using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models.BaoCao
{
    public class ReportCBNghiHuucs
    {
        public int? ID { set; get; }
        public string HoTen { set; get; }
        public string TenDonVi { set; get; }
        public int? DonViID { set; get; }
        public DateTime? NgaySinh_Nam { set; get; }
        public DateTime? NgaySinh_Nu { set; get; }
        public string TenChucVu { set; get; }
        public DateTime? NgayThongBaoNghiHuu { set; get; }
        public DateTime? NgayNghiHuu { set; get; }
        public string MaNgach { set; get; }
        public int? HeSo { set; get; }
    }
}
