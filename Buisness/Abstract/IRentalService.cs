using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IRentalService
    {
        IResult AddRental(Rental rental);

        IResult UpdateRental(Rental rental);

         IResult DeleteRental(Rental rental);
      
    }
}
