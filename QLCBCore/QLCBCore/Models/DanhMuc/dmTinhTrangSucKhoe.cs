using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmTinhTrangSucKhoe
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenTTSK { get; set; } // TenTTSK (length: 50)
        public bool? IsDeleted { get; set; } // IsDeleted
        public dmTinhTrangSucKhoe()
        {
            IsDeleted = false;
        }
    }

}
