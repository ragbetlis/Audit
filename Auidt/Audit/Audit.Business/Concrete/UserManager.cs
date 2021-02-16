using Audit.Business.Abstract;
using Audit.Business.Constants;
using Audit.DataAccess.Abstract;
using Audit.Entities.Concrete;
using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new Result(true, Messages.Listed);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.Listed);
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(p=>p.UserId==userId), Messages.Geted);
        }

        public IDataResult<User> GetByUserName(string userName)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.UserName == userName), Messages.Geted);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new Result(true, Messages.Updated);
        }
    }
}
