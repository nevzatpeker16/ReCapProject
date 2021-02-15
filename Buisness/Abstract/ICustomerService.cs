using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
   public  interface ICustomerService
    {
        IResult AddCustomer(Customer customer);

        IResult DeleteCustomer(Customer customer);


        IResult UpdateCustomer(Customer customer);
       
    }
}
