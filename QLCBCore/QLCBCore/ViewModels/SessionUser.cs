using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.ViewModels
{
    public class SessionUser
    {
        public int ID { get; set; }
        public int DonViID { get; set; }
        public string DonVi { get; set; }
        public string QuyenHan { get; set; }
        public int Level { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string DonViAllID { get; set; }
        public string Email { get; set; }
    }
}
