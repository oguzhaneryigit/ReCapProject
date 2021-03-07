using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        //////////////
        public IResult Add(User user)
        {
            if (true)
            {
                _userDal.Add(user);   
                return new SuccessResult("user eklendi");
            }
            else
            {
                return new ErrorResult("user eklenemedi");
            }
        }

        public IResult Delete(User user)
        {
            if (true)
            {
                _userDal.Delete(user);
                return new SuccessResult("user silindi");
            }
            else
            {
                return new ErrorResult("user silinemedi");
            }
        }
        public IResult Update(User user)
        {
            if (true)
            {
                _userDal.Update(user);
                return new SuccessResult("user güncellendi");
            }
            else
            {
                return new ErrorResult("user güncellenemedi");
            }
        }
        ////////////////
        public IDataResult<List<User>> GetAll(Expression<Func<User, bool>> filter = null)
        {
            List<User> data = _userDal.GetAll(filter);

            if (true)
            {
                return new SuccessDataResult<List<User>>(data);
            }
            else
            {
                return new ErrorDataResult<List<User>>();
            }
        }

    }
}
