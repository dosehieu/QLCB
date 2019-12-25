using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmQuanHam
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenQuanHam { get; set; } // TenQuanHam (length: 50)
        public bool? IsDeleted { get; set; } // IsDeleted
        public dmQuanHam()
        {
            IsDeleted = false;
        }
    }
}
