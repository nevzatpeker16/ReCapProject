using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IUserService
    {
        IResult AddUser(User user);


        IResult UpdateUser(User user);


        IResult DeleteUser(User user);
        IDataResult<List<User>> GetUsers();

        IDataResult<User> GetUsersById(int userID);
    }
}
