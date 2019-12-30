using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmKieuCanBo
    {
        public int ID { get; set; }
        public string TenKieuCanBo { get; set; }
        public bool? IsDeleted { get; set; }
        public virtual System.Collections.Generic.ICollection<CanBo> CanBo { get; set; } // CanBo.FK_CanBo_DanToc

        public dmKieuCanBo()
        {
            IsDeleted = false;
            CanBo = new System.Collections.Generic.List<CanBo>();

        }
    }
}
