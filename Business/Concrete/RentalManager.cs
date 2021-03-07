using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        private bool isRentableCar(Rental rental)
        {
            Rental notReturnedRental = _rentalDal.GetAll(r => r.ReturnDate == null).SingleOrDefault(r => r.CarId == rental.CarId);
            return notReturnedRental == null ? true : false;
            
        }
        public IResult Add(Rental rental)
        {
            
            if (isRentableCar(rental))
            {
                _rentalDal.Add(rental);
                return new SuccessResult("aracınız kiralandı");
            }
            else
            {
                return new ErrorResult("arac şuan kiralık --alamazsıınız");
            }
        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll(Expression<Func<Rental, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
