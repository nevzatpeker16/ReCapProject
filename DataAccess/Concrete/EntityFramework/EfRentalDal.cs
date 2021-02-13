using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
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
                             join cr in myDbContext.Cars on rn.CarID equals cr.CarID
                             join cus in myDbContext.Customers on rn.CustomerID equals cus.CustomerID
            }

        }
    }
}
