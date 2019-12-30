using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.ViewModels
{
    public class CanBoVM
    {
        public int ID { get; set; }
        [Display(Name = "Mã cán bộ")]
        public string Ma { get; set; }
        [Display(Name = "Hộ tên")]
        public string HoTen { get; set; }
        [Display(Name = "Giới tính")]
        public string GioiTinh { get; set; }
        [Display(Name = "Ngày sinh")]
        public string NgaySinh { get; set; }
        [Display(Name = "Tên đơn vị/ Phòng ban")]
        public string TenDonVi { get; set; }
        [Display(Name = "Kiểu cán bộ")]
        public string TenKieuCanBo { get; set; }
        [Display(Name = "Chức vụ")]
        public string TenChucVu { get; set; }
        [Display(Name = "Trình độ")]
        public string TenTrinhDo { get; set; } 

    }
}
