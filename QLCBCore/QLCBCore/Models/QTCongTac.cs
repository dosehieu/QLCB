using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class QTCongTac
    {
        public int ID { get; set; } // ID (Primary key)
        public int? CanBoID { get; set; } // CanBoID
        public string TuThangNam { get; set; } // TuThangNam (length: 10)
        public string DenThangNam { get; set; } // DenThangNam (length: 10)
        public string GhiChu { get; set; } // GhiChu (length: 500)
        public bool? isChuyenCT { get; set; } // isChuyenCT
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
