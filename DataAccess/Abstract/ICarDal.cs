using Core.Data_Access;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        //List<Car> GetAll();
        //List<Car> GetById(int Id);
        //void Add(Car car);
        //void Update(Car car);
        //void Delete(Car car);

        // IEntityRepository kullandıktan sonra burdaki metotları kaldırdık çünkü interface interface i inherit etti --implemente etmedi
        //

        // aşağıdaki fonksiyonlar sadece car classına özel

        List<CarDetailDto> GetCarDetails();

    }
}
