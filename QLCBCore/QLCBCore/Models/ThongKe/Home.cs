using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models.ThongKe
{
    public class Home
    {
        public Gender Genders { get; set; }
        public ClusterUser ClusterUsers { get; set; }
        public LevelUser LevelUsers { get; set; }
    }
}
