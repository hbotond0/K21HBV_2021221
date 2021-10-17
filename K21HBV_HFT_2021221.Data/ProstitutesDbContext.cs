using K21HBV_HFT_2021221.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Data
{
    public class ProstitutesDbContext : DbContext
    {
        public ProstitutesDbContext()
        {
            Database.EnsureCreated();
        }
        public ProstitutesDbContext(DbContextOptions<ProstitutesDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Prostitutes> Prostitutes { get; set; }
        public virtual DbSet<Pimps> Pimps { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder ez)
        {
            if (ez != null && !ez.IsConfigured)
            {
                ez.UseLazyLoadingProxies().UseSqlServer(@"data source=(LocalDB)\MSSQLLocalDB; Attachdbfilename=|DataDirectory|\MyDatabase.mdf; Integrated security=True; MultipleActiveResultSets=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // tables
            Pimps pimp1 = new Pimps() { Id = 1, Name = "IDK", NumOfGirls = 10 };

            Customers customer1 = new Customers() { Id = 1, Name = "Name", Age = 69, PimpId = pimp1.Id };

            Prostitutes prosti1 = new Prostitutes() { Id = 1, Name = "Name", Price = 420, PimpId = pimp1.Id };



            // connections
            modelBuilder.Entity<Prostitutes>(entity =>
            {
                entity.HasOne(prosti => prosti.Pimp)
                     .WithMany(pimp => pimp.Prostitutes)
                     .HasForeignKey(prosti => prosti.PimpId)
                     .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasOne(cust => cust.Pimp)
                     .WithMany(pimp => pimp.Customers)
                     .HasForeignKey(prosti => prosti.PimpId)
                     .OnDelete(DeleteBehavior.SetNull);
            });


            // adding
            modelBuilder.Entity<Customers>().HasData(customer1);
            modelBuilder.Entity<Pimps>().HasData(pimp1);
            modelBuilder.Entity<Prostitutes>().HasData(prosti1);
        }
    }
}

