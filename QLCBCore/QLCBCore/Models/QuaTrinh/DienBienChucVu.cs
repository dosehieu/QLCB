using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class DienBienChucVu
    {
        public int ID { get; set; } // ID (Primary key)

        [ForeignKey("CanBo")]
        [Display(Name = "Mã cán bộ")]
        public int? CanBoID { get; set; } // CanBoID

        [Display(Name = "Ngày bắt đầu")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime")]
        public System.DateTime? TuNgay { get; set; } // TuNgay

        [Display(Name = "Ngày kết thúc")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime")]
        public System.DateTime? DenNgay { get; set; } // DenNgay

        [ForeignKey("dmChucVu")]
        [Display(Name = "Chức vụ")]
        public int? ChucVuID { get; set; } // ChucVuID

        [Display(Name = "Phụ cấp chức vụ")]
        public float? PhuCapChucVu { get; set; } // PhuCapChucVu

        [Display(Name = "Curent")]
        public bool? Curent { get; set; } // Curent

        [Display(Name = "isLeader")]
        public bool? isLeader { get; set; } // isLeader

        [Display(Name = "Ngày bổ nhiệm")]

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime")]
        public System.DateTime? NgayBoNhiem { get; set; } // NgayBoNhiem

        [Display(Name = "Số quyết định")]
        public string SoQuyetDinh { get; set; } // SoQuyetDinh (length: 250)

        [Display(Name = "Người ký")]
        public string NguoiKy { get; set; } // NguoiKy (length: 255)

        [ForeignKey("dmDonVi")]
        [Display(Name = "Phòng ban")]
        public int? PhongBanID { get; set; } // PhongBanID

        [Display(Name = "Đảng - Đoàn")]
        public bool? IsDangDoan { get; set; } // IsDangDoan

        [Display(Name = "IsDeleted")]
        public bool? IsDeleted { get; set; } // IsDeleted

        // Foreign keys

        /// <summary>
        /// Parent CanBo pointed by [DienBienChucVu].([CanBoID]) (FK_DienBienChucVu_CanBo)
        /// </summary>
        public virtual CanBo CanBo { get; set; } // FK_DienBienChucVu_CanBo

        /// <summary>
        /// Parent dmChucVu pointed by [DienBienChucVu].([ChucVuID]) (FK_DienBienChucVu_dmChucVu)
        /// </summary>
        public virtual dmChucVu dmChucVu { get; set; } // FK_DienBienChucVu_dmChucVu

        public virtual dmDonVi dmDonVi { get; set; }

        public DienBienChucVu()
        {
            IsDeleted = false;
        }
    }
}
