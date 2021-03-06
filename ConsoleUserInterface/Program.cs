﻿using Buisness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager1 = new CarManager(new EfCarDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine("Burada Entity Framework ' u deneyeceğiz ");
            //            arabaGetir(carManager1);
            tumOzellikler(carManager1);

            ColorManager colorManager = new ColorManager(new EfColorDal());
            //            renkEkle(colorManager);
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //           markaEkle(brandManager);



        }
        private static void arabaKirala(RentalManager rentalManager)
        {
            Rental rental = new Rental { CarID = 1, CustomerID = 1, RentalDate = DateTime.Now, RentalID = 1 };
            rentalManager.AddRental(rental);


        }
        private static void renkEkle(ColorManager colorManager)
        {
            Color color1 = new Color
            {
                ColorID = 1,
                ColorName = "Kırmızı"
            };
            colorManager.AddColor(color1);
            Console.WriteLine("Renk eklendi , Eklenen renk  : {0}", color1.ColorName);
        }
        private static void markaEkle(BrandManager brandManager)
        {
            Brand brand1 = new Brand { BrandID = 1, BrandName = "Audi" };
            brandManager.AddBrand(brand1);
            Console.WriteLine("Marka eklendi {0}", brand1.BrandName);

        }
        private static void arabaGetir(CarManager carManager1)
        {
            var gelenAraba = carManager1.GetCars();
            if(gelenAraba.Success == true)
            {
                foreach (var araba in gelenAraba.Data)
                {
                    Console.WriteLine(araba.Description+ "  " +araba.DailyPrice + "  " +araba.ModelYear); ;
                }
            }

        }
        private static void tumOzellikler(CarManager carManager1)
        {
            int carID = 0;

            var carDetail = carManager1.GetCarDetail(carID);
            if (carDetail.Success == true)
            {
                foreach (var cardetail in carDetail.Data)
                {
                    Console.WriteLine(cardetail.BrandName + " " + cardetail.ColorName + " " + cardetail.DailyPrice + "  " + cardetail.Description + "  " + cardetail.ModelYear);
                }
            }
           

        }
    }
}
