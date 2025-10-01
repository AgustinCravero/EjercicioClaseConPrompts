using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesEjerPrompts.Models;

namespace ClasesEjerPrompts.Data
{
    public class AplicationDbContext : DbContext 
    {
        public DbSet<Vehiculo> Vehiculos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-291UIMG;Database=EjerPrompts;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
