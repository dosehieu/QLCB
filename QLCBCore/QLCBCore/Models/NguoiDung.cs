using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class NguoiDung
    {
        public int ID { get; set; } // ID (Primary key)
        public string FullName { get; set; } // FullName (length: 50)
        public System.DateTime? Birthday { get; set; } // Birthday
        public bool? Gender { get; set; } // Gender
        public string Email { get; set; } // Email (length: 50)
        public string UserName { get; set; } // UserName (length: 50)
        public string Password { get; set; } // Password (length: 16)
        public int? DonViID { get; set; } // DonViID
        public bool? IsDeleted { get; set; } // IsDeleted
    }
}
