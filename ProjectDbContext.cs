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

            modelBuilder.Entity<Ogrenci>().Property(o => o.Ad).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().Property(o => o.Numara).HasMaxLength(20).IsRequired().HasColumnType("varchar");


            modelBuilder.Entity<Ders>().Property(o => o.DersKod).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ders>().Property(o => o.DersAd).HasMaxLength(20).IsRequired().HasColumnType("varchar");

            modelBuilder.Entity<Sinif>().Property(o => o.SinifAd).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Sinif>().Property(o => o.SinifKontenjan).HasMaxLength(20).IsRequired().HasColumnType("varchar");



            modelBuilder.Entity<Ders>().HasKey(d => d.DersId);
            modelBuilder.Entity<Sinif>().HasKey(s => s.SinifId);

            modelBuilder.Entity<Ogrenci>()
                .HasOne(i => i.Sinif)
                .WithMany(i => i.Ogrenciler)
                .HasForeignKey(i => i.SinifId);


            modelBuilder.Entity<OgrenciDers>()
               .HasOne(a => a.Ders)
               .WithMany(a => a.OgrenciDersler)
               .HasForeignKey(a => a.DersId);


            modelBuilder.Entity<OgrenciDers>()
             .HasOne(a => a.Ogrenci)
             .WithMany(a => a.OgrenciDersler)
             .HasForeignKey(a => a.OgrenciId);
        }

    }
}
