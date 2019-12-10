using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmTonGiao
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenTonGiao { get; set; } // TenTonGiao (length: 50)
        public bool? IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child CanBo where [CanBo].[TonGiaoID] point to this entity (FK_CanBo_dmTonGiao)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<CanBo> CanBo { get; set; } // CanBo.FK_CanBo_dmTonGiao

        public dmTonGiao()
        {
            IsDeleted = false;
            CanBo = new System.Collections.Generic.List<CanBo>();
        }
    }
}
