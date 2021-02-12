using Buisness.Abstract;
using Buisness.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public class UserManager:IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult AddUser(User user)
        {

            _userDal.Add(user);
            return new SuccessResult(Messages.Added);
        }
        public IResult UpdateUser(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.Updated);
        }
        public IResult DeleteUser(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.Updated);
        }

    }
}
