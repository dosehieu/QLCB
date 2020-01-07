using Microsoft.AspNetCore.Mvc.Rendering;
using QLCBCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.ViewModels
{
    public class CanBoSapHetHanChucVuVM
    {

        public int ID { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string TenDonVi { get; set; }
        public string ChucVu { get; set; }
        public string NgayBoNhiem { get; set; }
        public string NgayHetHan { get; set; }
        public string TrangThai { get; set; }

        
    }
}
