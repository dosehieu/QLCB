using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class QLCBDbContext : DbContext
    {
        public QLCBDbContext() : base()
        {
            
        }
        DbSet<CanBo> CanBos;
    }
}
