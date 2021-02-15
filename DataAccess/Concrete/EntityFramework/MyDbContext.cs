using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class MyDbContext:DbContext
    {

        //Bu sınıfta veritabanı nesnelerimizi belirtiyoruz... burada tablolar liste halinde belirtilir.
        //Data setlerini ayarlıyoruz... 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UBP71HG;Database=MyCarDB;Trusted_Connection=true;Integrated Security=True;");
        }
     
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        

    }
}
