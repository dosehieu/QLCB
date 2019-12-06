using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class QLCBDbContext : DbContext
    {
        public QLCBDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<CanBo> CanBos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CanBo>().HasData(
                new CanBo() { ID = 1, HoTen = "John" },
                new CanBo() { ID = 2, HoTen = "Chris" },
                new CanBo() { ID = 3, HoTen = "Mukesh"});
        }
    }
}
