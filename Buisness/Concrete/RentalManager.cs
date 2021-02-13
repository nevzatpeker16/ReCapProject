using Buisness.Abstract;
using Buisness.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
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
            if(rental.CarID == null)
            {
                return new ErorResult("Araç ID boş geçilemez");
                
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

        public IDataResult<Rental> GetRentalByID(Rental rental)
        {
            _rentalDal.Get(p => p.RentalID == rental.RentalID);
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.RentalID == rental.RentalID), Messages.Listed);
        }
        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetail(), Messages.Listed);
        }
    }
}
