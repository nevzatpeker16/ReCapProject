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

        IDataResult<List<Customer>> ListCustomers();
        IResult UpdateCustomer(Customer customer);
       
    }
}
