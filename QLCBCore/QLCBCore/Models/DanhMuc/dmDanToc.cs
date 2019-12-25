using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmDanToc
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenDanToc { get; set; } // TenDanToc (length: 50)
        public bool? DanTocItNguoi { get; set; } // DanTocItNguoi
        public bool? IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child CanBo where [CanBo].[DanTocID] point to this entity (FK_CanBo_DanToc)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<CanBo> CanBo { get; set; } // CanBo.FK_CanBo_DanToc

        public dmDanToc()
        {
            IsDeleted = false;
            CanBo = new System.Collections.Generic.List<CanBo>();

        }
    }
}
