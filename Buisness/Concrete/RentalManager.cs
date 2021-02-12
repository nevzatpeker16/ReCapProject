using Buisness.Abstract;
using Buisness.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public  class RentalManager:IRentalService
    {
       IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult AddRental(Rental rental)
        {
            if(rental.ReturnDate == null)
            {
                return new ErorResult("Bu araç ne yazık ki iade edilmemiş");
            }
            else {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.Added);
            }

            
        }
        public IResult UpdateRental(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
        public IResult DeleteRental(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

    }
}
