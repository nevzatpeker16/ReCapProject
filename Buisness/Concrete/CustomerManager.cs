using Buisness.Abstract;
using Buisness.Constants;
using Buisness.ValidationRules;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public class CustomerManager:ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult AddCustomer(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.Added);
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult DeleteCustomer(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.Deleted);
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult UpdateCustomer(Customer customer)
        {
            _customerDal.Update(customer);
                return new SuccessResult(Messages.Updated);
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public IDataResult<List<Customer>> ListCustomers()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.getAll(),Messages.Listed);
        }
    }
}
