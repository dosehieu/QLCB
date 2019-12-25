using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmKyLuat
    {
        public byte ID { get; set; } // ID (Primary key)
        public string MaKyLuat { get; set; } // MaKyLuat (length: 5)
        public string TenKyLuat { get; set; } // TenKyLuat (length: 100)
        public bool? IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child QTKyLuat where [QTKyLuat].[KyLuatID] point to this entity (FK_QTKyLuat_dmKyLuat)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<QTKyLuat> QTKyLuat { get; set; } // QTKyLuat.FK_QTKyLuat_dmKyLuat

        public dmKyLuat()
        {
            IsDeleted = false;
            QTKyLuat = new System.Collections.Generic.List<QTKyLuat>();
        }
    }
}
