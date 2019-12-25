using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmChucDanhKhoaHoc
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenChucDanhKhoaHoc { get; set; } // TenChucDanhKhoaHoc (length: 50)
        public bool? IsDeleted { get; set; } // IsDeleted
        public dmChucDanhKhoaHoc()
        {
            IsDeleted = false;
        }
    }
    
}
