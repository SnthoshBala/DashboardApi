using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardApi.Model
{
    public class AcceleratorContext : DbContext
    {
        private const string connection = "Server=KANINI-LTP-487\\MSQLSERVERSB007;Database=coeportal;Trusted_Connection=True;";

        public AcceleratorContext()
        {

        }

        public AcceleratorContext(DbContextOptions<AcceleratorContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }

        public DbSet<Accelerator> accelerators { get; set; }

    }
}

