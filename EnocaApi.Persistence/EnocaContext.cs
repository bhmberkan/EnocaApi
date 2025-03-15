using EnocaApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Persistence
{
    public class EnocaContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AV1UIG0; initial Catalog=ApiEnocaDb; integrated Security=true;  TrustServerCertificate=Yes");
        }

        public DbSet<CarrierConfigurations> CarrierConfigurations { get; set; }
        public DbSet<Carriers> Carriers { get; set; }
        public DbSet<Orders> Orders { get; set; }

    }
}
