using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class QTKyLuat
    {
        public int ID { get; set; } // ID (Primary key)


        [ForeignKey("CanBo")]
        [Display(Name = "Cán bộ")]
        public int? CanBoID { get; set; } // CanBoID

        [Display(Name = "Ngày kỷ luật")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime")]
        public System.DateTime? NgayKyLuat { get; set; } // NgayKyLuat

        [ForeignKey("dmKyLuat")]
        [Display(Name = "Mã kỷ luật")]
        public byte? KyLuatID { get; set; } // KyLuatID

        [Display(Name = "Nội dung")]
        public string NoiDung { get; set; } // NoiDung (length: 250)


        [Display(Name = "Is Cao nhất")]
        public bool? IsCaoNhat { get; set; } // IsCaoNhat

        [Display(Name = "Số quyết định")]
        public string SoQuyetDinh { get; set; } // SoQuyetDinh (length: 50)

        [Display(Name = "Cơ quan ban hành quyết định")]
        public string CoQuanBanHanhQD { get; set; } // CoQuanBanHanhQD (length: 250)

        [Display(Name = "IsDeleted")]
        public bool? IsDeleted { get; set; } // IsDeleted

        // Foreign keys

        /// <summary>
        /// Parent CanBo pointed by [QTKyLuat].([CanBoID]) (FK_QTKyLuat_CanBo)
        /// </summary>
        public virtual CanBo CanBo { get; set; } // FK_QTKyLuat_CanBo

        /// <summary>
        /// Parent dmKyLuat pointed by [QTKyLuat].([KyLuatID]) (FK_QTKyLuat_dmKyLuat)
        /// </summary>
        public virtual dmKyLuat dmKyLuat { get; set; } // FK_QTKyLuat_dmKyLuat

        public QTKyLuat()
        {
            IsDeleted = false;
        }
    }
}
