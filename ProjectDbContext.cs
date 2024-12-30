using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ntpfinalApp
{
    internal class ProjectDbContext:DbContext
 
    {
        public DbSet<OgrenciDers> OgrenciDers {  get; set; } 
        public DbSet<Sinif> Siniflar { get; set; }    
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog= ObsDbSube2; Integrated Security=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OgrenciDers>().HasKey(od => new { od.OgrenciId, od.DersId });
            


            modelBuilder.Entity<Ders>().HasKey(d => d.DersId);
            modelBuilder.Entity<Sinif>().HasKey(s => s.SinifId);
                

        }

    }
}
