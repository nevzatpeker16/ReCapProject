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
    public class UserManager:IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult AddUser(User user)
        {

            _userDal.Add(user);
            return new SuccessResult(Messages.Added);
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult UpdateUser(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.Updated);
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult DeleteUser(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.Updated);
        }
        [ValidationAspect(typeof(UserValidator))]

        public IDataResult<List<User>> GetUsers()
        {

            return new SuccessDataResult<List<User>>(_userDal.getAll(), Messages.Listed);
        }
        [ValidationAspect(typeof(UserValidator))]
        public IDataResult<User> GetUsersById(int userID)
        {
            return new SuccessDataResult<User>(_userDal.Get(p=>p.UserID == userID), Messages.Listed);
        }
    }
}
