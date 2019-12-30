using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmTrinhDo
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenTrinhDo { get; set; } // TenTrinhDo (length: 150)
        public bool? IsDeleted { get; set; } // IsDeleted
        public virtual System.Collections.Generic.ICollection<CanBo> CanBo { get; set; } // CanBo.FK_CanBo_TrinhDoPhoThong

        public dmTrinhDo()
        {
            IsDeleted = false;
            CanBo = new System.Collections.Generic.List<CanBo>();
        }
    }
}
