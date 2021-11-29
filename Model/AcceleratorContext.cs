using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardApi.Model
{
    public class AcceleratorContext : DbContext
    {
        private const string connection = "Server=tcp:coeportal.database.windows.net,1433;Initial Catalog=Coeportal;Persist Security Info=False;User ID=coeportal;Password=Raguraman@007;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

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

