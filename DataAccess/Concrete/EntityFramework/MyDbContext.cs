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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyCarDB;Trusted_Connection=true;");
        }
        //Data setlerini ayarlıyoruz... 
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }

    }
}
