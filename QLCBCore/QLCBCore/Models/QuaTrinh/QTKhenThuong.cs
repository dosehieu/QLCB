using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class QTKhenThuong
    {
        public int ID { get; set; } // ID (Primary key)

        [ForeignKey("CanBo")]
        [Display(Name = "Mã cán bộ")]
        public int? CanBoID { get; set; } // CanBoID


        [ForeignKey("dmHinhThucKhenThuong")]
        [Display(Name = "Hình thức khen thưởng")]
        public byte? HinhThucKhenThuongID { get; set; } // HinhThucKhenThuongID

        [Display(Name = "Nội dung")]
        public string NoiDung { get; set; } // NoiDung (length: 250)

        [Display(Name = "Ngày khen thưởng")]
        public string NgayKhenThuong { get; set; } // NgayKhenThuong (length: 10)

        [Display(Name = "Cao nhất")]
        public bool? IsCaoNhat { get; set; } // IsCaoNhat

        [Display(Name = "Số quyết định")]
        public string SoQuyetDinh { get; set; } // SoQuyetDinh (length: 50)

        [Display(Name = "Ngày ký")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime")]
        public System.DateTime? NgayKy { get; set; } // NgayKy

        [Display(Name = "Cơ quan ban hành")]
        public string CoQuanBanHanhQD { get; set; } // CoQuanBanHanhQD (length: 250)

        [Display(Name = "Khen thưởng")]
        public bool? IsKhenThuong { get; set; } // IsKhenThuong

        [Display(Name = "Mục khen thưởng")]
        public int? MucKhenThuong { get; set; } // MucKhenThuong

        [Display(Name = "IsDeleted")]
        public bool? IsDeleted { get; set; } // IsDeleted

        // Foreign keys

        /// <summary>
        /// Parent dmHinhThucKhenThuong pointed by [QTKhenThuong].([HinhThucKhenThuongID]) (FK_QTKhenThuong_dmHinhThucKhenThuong)
        /// </summary>
        public virtual dmHinhThucKhenThuong dmHinhThucKhenThuong { get; set; } // FK_QTKhenThuong_dmHinhThucKhenThuong

        public virtual CanBo CanBo { get; set; } // FK_QTKhenThuong_dmHinhThucKhenThuong

        public QTKhenThuong()
        {
            IsKhenThuong = false;
            IsDeleted = false;
        }
    }
}
