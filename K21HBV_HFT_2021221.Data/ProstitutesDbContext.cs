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
            Pimps pimp1 = new Pimps() { Id = 1, Name = "John Doe", CostumerRating = 2 };
            Pimps pimp2 = new Pimps() { Id = 2, Name = "Arthur Doyle", CostumerRating = 7 };
            Pimps pimp3 = new Pimps() { Id = 3, Name = "Andrew", CostumerRating = 1 };
            Pimps pimp4 = new Pimps() { Id = 4, Name = "Jasmine Jane", CostumerRating = 5 };
            Pimps pimp5 = new Pimps() { Id = 5, Name = "Lukas Crosby", CostumerRating = 10 };

            Customers customer1 = new Customers() { Id = 1, Name = "Name", Age = 20, PimpId = pimp5.Id };
            Customers customer2 = new Customers() { Id = 2, Name = "Name", Age = 33, PimpId = pimp5.Id };
            Customers customer3 = new Customers() { Id = 3, Name = "Name", Age = 69, PimpId = pimp5.Id };
            Customers customer4 = new Customers() { Id = 4, Name = "Name", Age = 26, PimpId = pimp1.Id };
            Customers customer5 = new Customers() { Id = 5, Name = "Name", Age = 33, PimpId = pimp2.Id };
            Customers customer6 = new Customers() { Id = 6, Name = "Name", Age = 49, PimpId = pimp3.Id };
            Customers customer7 = new Customers() { Id = 7, Name = "Name", Age = 52, PimpId = pimp2.Id };
            Customers customer8 = new Customers() { Id = 8, Name = "Name", Age = 42, PimpId = pimp1.Id };

            Prostitutes prosti1 = new Prostitutes() { Id = 1, Name = "Horny Maddie", Age = 44, Price = 420,STDs = true, PimpId = pimp1.Id };
            Prostitutes prosti2 = new Prostitutes() { Id = 2, Name = "Goddess Trinity", Age = 22, Price = 1531, STDs = false, PimpId = pimp1.Id };
            Prostitutes prosti3 = new Prostitutes() { Id = 3, Name = "Kinky Maya", Age = 20, Price = 512, STDs = false, PimpId = pimp3.Id };
            Prostitutes prosti4 = new Prostitutes() { Id = 4, Name = "Milf Evelyn", Age = 56, Price = 121, STDs = false, PimpId = pimp4.Id };
            Prostitutes prosti5 = new Prostitutes() { Id = 5, Name = "Wild Riley", Age = 36, Price = 523, STDs = false, PimpId = pimp2.Id };
            Prostitutes prosti6 = new Prostitutes() { Id = 6, Name = "Big booty Lexy", Age = 24, Price = 1234, STDs = false, PimpId = pimp2.Id };
            Prostitutes prosti7 = new Prostitutes() { Id = 7, Name = "Bunny Jasmine", Age = 30, Price = 234, STDs = false, PimpId = pimp5.Id };
            Prostitutes prosti8 = new Prostitutes() { Id = 8, Name = "Nimfomaniac Amber", Age = 50, Price = 69, STDs = true, PimpId = pimp5.Id };



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
            modelBuilder.Entity<Customers>().HasData(customer1, customer2, customer3, customer4, customer5, customer6, customer7, customer8);
            modelBuilder.Entity<Pimps>().HasData(pimp1, pimp2, pimp3, pimp4, pimp5);
            modelBuilder.Entity<Prostitutes>().HasData(prosti1, prosti2, prosti3, prosti4, prosti5, prosti6, prosti7, prosti8);
        }
    }
}

