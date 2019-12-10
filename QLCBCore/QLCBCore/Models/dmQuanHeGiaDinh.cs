using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmQuanHeGiaDinh
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenQuanHeGD { get; set; } // TenQuanHeGD (length: 50)
        public int? ThuTu { get; set; } // ThuTu
        public bool? IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child QuanHeGiaDinh where [QuanHeGiaDinh].[QuanHeGDID] point to this entity (FK_QuanHeGiaDinh_dmQuanHeGiaDinh)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<QuanHeGiaDinh> QuanHeGiaDinh { get; set; } // QuanHeGiaDinh.FK_QuanHeGiaDinh_dmQuanHeGiaDinh

        public dmQuanHeGiaDinh()
        {
            IsDeleted = false;
            QuanHeGiaDinh = new System.Collections.Generic.List<QuanHeGiaDinh>();
        }
    }
}
