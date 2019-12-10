using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmHangThuongBinh
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenHangThuongBinh { get; set; } // TenHangThuongBinh (length: 50)
        public bool? IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child CanBo where [CanBo].[HangThuongBinhID] point to this entity (FK_CanBo_dmHangThuongBinh)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<CanBo> CanBo { get; set; } // CanBo.FK_CanBo_dmHangThuongBinh

        public dmHangThuongBinh()
        {
            IsDeleted = false;
            CanBo = new System.Collections.Generic.List<CanBo>();
        }
    }
}
