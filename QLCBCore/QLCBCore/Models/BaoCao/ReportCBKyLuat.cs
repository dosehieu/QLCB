﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models.BaoCao
{
    public class ReportCBKyLuat
    {
        public int? ID { get; set; }
        public string DonVi { get; set; }
        public string TenTrinhDo { get; set; }
        public int? KieuCanBo { get; set; }
        public string TenKieuCanBo { get; set; }
        public int? STTDonVi { get; set; }
        public int? ChucVuSTT { get; set; }
        public int? CanBoID { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public bool? GioiTinh { get; set; }
        public string TenDonVi { get; set; }
        public string TenPhongBan { get; set; }
        public int? ChucVuID { get; set; }
        public string TenChucVu { get; set; }
        public int? RegionID { get; set; }
        public int? Nam { get; set; }
        public string NoiDung { get; set; }
        public string HinhThucKyLuat { get; set; }
    }
}
