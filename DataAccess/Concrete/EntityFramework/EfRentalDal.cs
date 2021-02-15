using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, MyDbContext> , IRentalDal
    {
        public EfRentalDal()
        {

        }
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                var result = from rn in myDbContext.Rentals
                             join cd in myDbContext.Cars on rn.CarID equals cd.CarID
                             join col in myDbContext.Colors on cd.ColorID equals col.ColorID
                             join br in myDbContext.Brands on cd.BrandID equals br.BrandID
                             join cus in myDbContext.Customers on rn.CustomerID equals cus.CustomerID
                             join us in myDbContext.Users on cus.CustomerID equals us.UserID
                             select new RentalDetailDto
                             {
                                RentalID = rn.RentalID,
                                BrandName = br.BrandName,
                                CarID = cd.CarID,
                                CompanyName = cus.CompanyName,
                                DailyPrice = cd.DailyPrice,
                                CustomerID = cus.CustomerID,
                                Description = cd.Description,
                                Email = us.Email,
                                FirstName = us.FirstName,
                                LastName = us.LastName,
                                ModelYear = cd.ModelYear,
                                Password = us.Password,
                                RentalDate = rn.RentalDate,
                                ReturnDate = rn.ReturnDate,
                                UserID = us.UserID
                                 
                             };


                             return result.ToList();
            }

        }
    }
}
