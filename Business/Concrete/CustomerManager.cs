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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            if (true)
            {
                _customerDal.Add(customer);
                return new SuccessResult("user eklendi");
            }
            else
            {
                return new ErrorResult("user eklenemedi");
            }
        }

        public IResult Delete(Customer customer)
        {
            if (true)
            {
                _customerDal.Delete(customer);
                return new SuccessResult("user silindi");
            }
            else
            {
                return new ErrorResult("user silinemedi");
            }
        }

        public IDataResult<List<Customer>> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            List<Customer> data = _customerDal.GetAll(filter);

            if (true)
            {
                return new SuccessDataResult<List<Customer>>(data);
            }
            else
            {
                return new ErrorDataResult<List<Customer>>();
            }
        }

        public IResult Update(Customer customer)
        {
            if (true)
            {
                _customerDal.Update(customer);
                return new SuccessResult("user güncellendi");
            }
            else
            {
                return new ErrorResult("user güncellenemedi");
            }
        }
    }
}
