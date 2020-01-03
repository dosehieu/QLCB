using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmGiaDinhCS
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenGiaDinhCS { get; set; } // TenGiaDinhChinhSach (length: 50)
        public bool? IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child CanBo where [CanBo].[GiaDinhCSID] point to this entity (FK_CanBo_dmGiaDinhCS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<CanBo> CanBo { get; set; } // CanBo.FK_CanBo_dmGiaDinhCS


        public dmGiaDinhCS()
        {
            IsDeleted = false;
            CanBo = new System.Collections.Generic.List<CanBo>();
        }
    }
}
