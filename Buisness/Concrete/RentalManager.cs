using Buisness.Abstract;
using Buisness.Constants;
using Buisness.ValidationRules;
using Core.Aspect.Autofac.Validation;
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
        [ValidationAspect(typeof(RentalValidator))]
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
        [ValidationAspect(typeof(RentalValidator))]
        public IResult UpdateRental(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult DeleteRental(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IDataResult<Rental> GetRentalByID(Rental rental)
        {
            _rentalDal.Get(p => p.RentalID == rental.RentalID);
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.RentalID == rental.RentalID), Messages.Listed);
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetail(), Messages.Listed);
        }
    }
}
