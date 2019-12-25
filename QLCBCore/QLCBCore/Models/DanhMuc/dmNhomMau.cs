using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmNhomMau
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenNhomMau { get; set; } // TenNhomMau (length: 50)
        public bool? IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child CanBo where [CanBo].[NhomMauID] point to this entity (FK_CanBo_NhomMau)
        /// </summary>
        public virtual ICollection<CanBo> CanBo { get; set; } // CanBo.FK_CanBo_NhomMau
        public dmNhomMau()
        {
            IsDeleted = false;
            CanBo = new List<CanBo>();
        }
    }

}
