using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class QTCongTac
    {
        public int ID { get; set; } // ID (Primary key)

        [ForeignKey("CanBo")]
        [Display(Name = "Mã cán bộ")]
        public int? CanBoID { get; set; } // CanBoID

        [Display(Name = "Từ tháng năm")]
        public string TuThangNam { get; set; } // TuThangNam (length: 10)

        [Display(Name = "Đến tháng năm")]
        public string DenThangNam { get; set; } // DenThangNam (length: 10)

        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; } // GhiChu (length: 500)

        [Display(Name = "Chuyển công tác")]
        public bool? isChuyenCT { get; set; } // isChuyenCT

        [Display(Name = "IsDeleted")]
        public bool? IsDeleted { get; set; } // IsDeleted

        // Foreign keys

        /// <summary>
        /// Parent CanBo pointed by [QTCongTac].([CanBoID]) (FK_QuaTrinhCongTac_CanBo)
        /// </summary>
        public virtual CanBo CanBo { get; set; } // FK_QuaTrinhCongTac_CanBo

        public QTCongTac()
        {
            isChuyenCT = false;
            IsDeleted = false;
        }
    }
}
