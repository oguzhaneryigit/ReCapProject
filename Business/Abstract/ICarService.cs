using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll(Expression<Func<Car, bool>> filter = null);

        //Car Get(Expression<Func<Car, bool>> filter);
        List<Car> GetCarsByBrandId(int Id);
        List<Car> GetCarsByColorId(int Id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
