using Buisness.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public  class RentalManager:IRentalService
    {
       IRentalDal _IrentalDal;
    }
}
