using E_HekimogluAPI.Domain.Entities;
using E_HekimogluAPI.Domain.Entities.BagcikMalzemesi;
using E_HekimogluAPI.Domain.Entities.Kesimhane;
using E_HekimogluAPI.Domain.Entities.KutuKoli;
using E_HekimogluAPI.Domain.Entities.Taban;
using E_HekimogluAPI.Domain.Entities.TutkalMalzemesi;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Persistence.Context
{
    public class EHekimogluApiDbContext : IdentityDbContext
    {
        public EHekimogluApiDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Beden> Bedens { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cinsiyet> Cinsiyets { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Renk> Renks { get; set; }

        //for Otomasyon
        public DbSet<Bagcik> Bagciks { get; set; }
        public DbSet<BagcikKategori> BagcikKategoris { get; set; }

        public DbSet< KesimKategori> KesimKategoris { get; set; }
        public DbSet<KesimMalzeme> KesimMalzemes { get; set; }
        public DbSet<MalzemeRaf> MalzemeRafs { get; set; }

        public DbSet<Koli>  Koli { get; set; }
        public DbSet<KoliKategori> KoliKategoris { get; set; }

        public DbSet<TabanKategori> TabanKategoris  { get; set; }
        public DbSet<TabanKayıt>TabanKayıts { get; set; }

        public DbSet<Tutkal>  Tutkals { get; set; }
        public DbSet<TutkalKategori> TutkalKategoris { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            

           builder.Entity<Product>()
          .HasIndex(p => p.ProductCode)
          .IsUnique();

            builder.Entity<KesimMalzeme>()
                .HasIndex(c=>c.Barkod).IsUnique();
            builder.Entity<TabanKayıt>()
                .HasIndex(c => c.Barkod).IsUnique();
            builder.Entity<Tutkal>()
                .HasIndex(c => c.Barkod).IsUnique();
            builder.Entity<Bagcik>()
                .HasIndex(c => c.Barkod).IsUnique();
            builder.Entity<Koli>()
                .HasIndex(c => c.Barkod).IsUnique();
            //builder.Entity<Product>()
            // .HasOne(c => c.Markas)
            // .WithMany(c => c.products);

            //KesimMalzemesi ilşkileri
            builder.Entity<KesimMalzeme>()
                .HasOne(c => c.KesimKategori)
                .WithMany(c => c.KesimMalzemes);

            builder.Entity<KesimMalzeme>()
                .HasOne(c => c.Renk)
                .WithMany(c => c.RenkKesimMalzemes);

            builder.Entity<KesimMalzeme>()
                .HasOne(c => c.MalzemeRaf)
                .WithMany(c => c.KesimMalzemes);

            //Taban ilşkileri
            builder.Entity<TabanKayıt>()
                .HasOne(c => c.TabanKategori)
                .WithMany(c => c.TabanKayıts);
            builder.Entity<TabanKayıt>()
                .HasMany(c => c.Renks)
                .WithMany(c => c.TabanKayıts);

            //tutkal ilişkiler
            builder.Entity<Tutkal>()
                .HasOne(c => c.TutkalKategori)
                .WithMany(c => c.Tutkals);

            //Kutu koli ilişkiler
            builder.Entity<Koli>()
                .HasOne(c => c.KoliKategori)
                .WithMany(c => c.Kolis);

            base.OnModelCreating(builder);
        }
    }
}
