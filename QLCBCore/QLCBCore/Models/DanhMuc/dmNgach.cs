using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmNgach
    {
        public int ID { get; set; } // ID (Primary key)
        public int? NhomNgachID { get; set; } // NhomNgachID
        public string MaNgach { get; set; } // MaNgach (length: 10)
        public string TenNgach { get; set; } // TenNgach (length: 200)
        public string LoaiNgach { get; set; } // LoaiNgach (length: 5)
        public int? PCVK { get; set; } // PCVK
        public bool? IsDeleted { get; set; } // IsDeleted

        public virtual System.Collections.Generic.ICollection<DienBienNgachBac> DienBienNgachBac { get; set; }
        public dmNgach()
        {
            IsDeleted = false;
            DienBienNgachBac = new System.Collections.Generic.List<DienBienNgachBac>();
        }
    }
    
}
