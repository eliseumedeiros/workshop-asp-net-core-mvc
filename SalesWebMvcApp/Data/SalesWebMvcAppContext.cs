using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcApp.Models;

namespace SalesWebMvcApp.Data
{
    public class SalesWebMvcAppContext : DbContext
    {
        public SalesWebMvcAppContext (DbContextOptions<SalesWebMvcAppContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvcApp.Models.Department> Department { get; set; }
    }
}
