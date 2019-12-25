using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class QTKyLuat
    {
        public int ID { get; set; } // ID (Primary key)
        public int? CanBoID { get; set; } // CanBoID
        public System.DateTime? NgayKyLuat { get; set; } // NgayKyLuat
        public byte? KyLuatID { get; set; } // KyLuatID
        public string NoiDung { get; set; } // NoiDung (length: 250)
        public bool? IsCaoNhat { get; set; } // IsCaoNhat
        public string SoQuyetDinh { get; set; } // SoQuyetDinh (length: 50)
        public string CoQuanBanHanhQD { get; set; } // CoQuanBanHanhQD (length: 250)
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
