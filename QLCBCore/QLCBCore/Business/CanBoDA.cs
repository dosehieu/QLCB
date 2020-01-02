using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using QLCBCore.Models;
using QLCBCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using System.Threading.Tasks;

namespace QLCBCore.Business
{
    
    public class CanBoDA
    {
        private readonly QLCBDbContext _context;

        public CanBoDA(QLCBDbContext context)
        {
            _context = context;
        }
        
    }
}
