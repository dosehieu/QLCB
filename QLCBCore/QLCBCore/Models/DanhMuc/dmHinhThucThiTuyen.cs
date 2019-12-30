using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models

{
    public class dmHinhThucThiTuyen
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenHinhThucTT { get; set; } // TenHinhThucTD (length: 150)
        public bool? IsDeleted { get; set; } // IsDeleted

        public dmHinhThucThiTuyen()
        {
            IsDeleted = false;
        }
    }
}
