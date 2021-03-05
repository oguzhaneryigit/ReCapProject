using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car(){Id=1,BrandId=1,ColorId=10,DailyPrice=10000,Description="Suv",ModelYear="2015"},
                new Car(){Id=2,BrandId=2,ColorId=105,DailyPrice=10000,Description="MotoCycle",ModelYear="2015"},
                new Car(){Id=3,BrandId=2,ColorId=13,DailyPrice=10000,Description="Sedan",ModelYear="2015"},
                new Car(){Id=4,BrandId=3,ColorId=50,DailyPrice=10000,Description="Vagon",ModelYear="2015"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car toDelete = _cars.SingleOrDefault(c => car.Id == c.Id);
            _cars.Remove(toDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=>c.Id==Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car toUpdate= _cars.SingleOrDefault(c=>car.Id==c.Id);
            
            toUpdate.BrandId = car.BrandId;
            toUpdate.ColorId = car.ColorId;
            toUpdate.DailyPrice = car.DailyPrice;
            toUpdate.Description = car.Description;
            toUpdate.ModelYear = car.ModelYear;


        }
    }
}
