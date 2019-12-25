using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmHocHam
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenHocHam { get; set; } // TenHinhThucTD (length: 150)
        public bool? IsDeleted { get; set; } // IsDeleted

        public dmHocHam()
        {
            IsDeleted = false;
        }
    }
}
