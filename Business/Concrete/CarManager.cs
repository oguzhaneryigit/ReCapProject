using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        // business Data ve Entities ile çalışır
        // iş kodları
        // if else vs
        // yetkisi var mı?

        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        //
        public IResult Add(Car car)
        {
            if (car.DailyPrice>=0&&car.Description.Length>=2)
            {
                _carDal.Add(car);
                return new SuccessResult("ürün eklendi");
            }
            else
            {
                return new ErrorResult("ürün eklenemedi");
            }
        }
        public IResult Delete(Car car)
        {
            if (true)
            {
                _carDal.Delete(car);
                return new SuccessResult("ürün silindi");
            }
            else
            {
                return new ErrorResult("ürün silinemedi");
            }
        }
        public IResult Update(Car car)
        {
            if (car.DailyPrice >= 0 && car.Description.Length >= 2)
            {
                _carDal.Update(car);
                return new SuccessResult("ürün güncellendi");
            }
            else
            {
                return new ErrorResult("ürün güncellenemedi");
            }
        }
        //
        //public Car Get()
        //{
        //    return _carDal.Get();
        //}

        public IDataResult<List<Car>> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            List<Car> data=_carDal.GetAll(filter);

            if (true)
            {
                return new SuccessDataResult<List<Car>>(data);
            }
            else
            {
                return new ErrorDataResult<List<Car>>();
            }
        }

        public IDataResult<List<CarDetailDto>>  GetCarDetails()
        {
            List<CarDetailDto> data =  _carDal.GetCarDetails();
            if (true)
            {
                return new SuccessDataResult<List<CarDetailDto>> (data);
            }
            else
            {
                return new ErrorDataResult<List<CarDetailDto>>();
            }
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int Id)
        {
            List<Car> data = _carDal.GetAll(c => c.BrandId == Id);

            if (true)
            {
                return new SuccessDataResult<List<Car>>(data);
            }
            else
            {
                return new ErrorDataResult<List<Car>>();
            }
        }

        public IDataResult<List<Car>> GetCarsByColorId(int Id)
        {
            List<Car> data = _carDal.GetAll(c => c.ColorId == Id);

            if (true)
            {
                return new SuccessDataResult<List<Car>>(data);
            }
            else
            {
                return new ErrorDataResult<List<Car>>();
            }
        }

        
    }
}
