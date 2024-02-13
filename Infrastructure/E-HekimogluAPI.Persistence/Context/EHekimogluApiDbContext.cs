using E_HekimogluAPI.Domain.Entities;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
 

           builder.Entity<Product>()
          .HasIndex(p => p.ProductCode)
          .IsUnique();

            //builder.Entity<Product>()
            // .HasOne(c => c.Markas)
            // .WithMany(c => c.products);


            base.OnModelCreating(builder);
        }
    }
}
