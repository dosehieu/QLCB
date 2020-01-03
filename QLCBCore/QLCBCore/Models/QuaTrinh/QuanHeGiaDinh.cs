using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class QuanHeGiaDinh
    {
        public int ID { get; set; } // ID (Primary key)

        [ForeignKey("CanBo")]
        [Display(Name = "Cán bộ")]
        public int? CanBoID { get; set; } // CanBoID

        [ForeignKey("dmQuanHeGiaDinh")]
        [Display(Name = "Quan hệ gia đình")]
        public int? QuanHeGDID { get; set; } // QuanHeGDID

        [Display(Name = "Họ tên")]
        public string HoTen { get; set; } // HoTen (length: 150)

        [Display(Name = "Năm sinh")]
        public string NamSinh { get; set; } // NamSinh (length: 10)

        [Display(Name = "Nghề nghiệp")]
        public string NgheNghiep { get; set; } // NgheNghiep (length: 150)

        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; } // GhiChu (length: 500)

        [Display(Name = "Thông tin khac")]
        public string ThongTinKhac { get; set; } // ThongTinKhac (length: 100)

        [Display(Name = "Thông tin TCXH")]
        public string ThongTinTCXH { get; set; } // ThongTinTCXH (length: 100)

        [Display(Name = "Quê quán")]
        public string QueQuan { get; set; } // QueQuan (length: 100)

        ///<summary>
        /// 0:Nội;1:Ngoại
        ///</summary>
        ///

        [Display(Name = "Type")]
        public int? Type { get; set; } // Type

        [Display(Name = "IsDeleted")]
        public bool? IsDeleted { get; set; } // IsDeleted

        [Display(Name = "Chức vụ")]
        public string ChucVu { get; set; } // ChucVu (length: 200)

        [Display(Name = "Cơ quan")]
        public string CoQuan { get; set; } // CoQuan (length: 200)

        [Display(Name = "Hộ khẩu")]
        public string HoKhau { get; set; } // HoKhau (length: 200)

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; } // DiaChi (length: 200)

        // Foreign keys

        /// <summary>
        /// Parent CanBo pointed by [QuanHeGiaDinh].([CanBoID]) (FK_QuanHeGiaDinh_CanBo)
        /// </summary>
        public virtual CanBo CanBo { get; set; } // FK_QuanHeGiaDinh_CanBo

        /// <summary>
        /// Parent dmQuanHeGiaDinh pointed by [QuanHeGiaDinh].([QuanHeGDID]) (FK_QuanHeGiaDinh_dmQuanHeGiaDinh)
        /// </summary>
        public virtual dmQuanHeGiaDinh dmQuanHeGiaDinh { get; set; } // FK_QuanHeGiaDinh_dmQuanHeGiaDinh

        public QuanHeGiaDinh()
        {
            IsDeleted = false;
        }
    }
}
