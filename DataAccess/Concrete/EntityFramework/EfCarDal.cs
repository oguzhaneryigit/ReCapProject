using Core.Data_Access.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarMarketContext>, ICarDal
    {

        //
        // aşağıdaki fonksiyonlar EfEntityRepositoryBase den implemente edildi
        //

        //public void Add(Car entity)
        //{
        //    using (CarMarketContext context = new CarMarketContext())
        //    {
        //        var addedEntity = context.Entry(entity);
        //        addedEntity.State = EntityState.Added;
        //        context.SaveChanges();
        //    }
        //}

        //public void Delete(Car entity)
        //{
        //    using (CarMarketContext context = new CarMarketContext())
        //    {
        //        var deletedEntity = context.Entry(entity);
        //        deletedEntity.State = EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}

        //public Car Get(Expression<Func<Car, bool>> filter)
        //{
        //    using (CarMarketContext context = new CarMarketContext())
        //    {
        //        return context.Set<Car>().SingleOrDefault(filter);
        //    }
        //}

        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    using (CarMarketContext context = new CarMarketContext())
        //    {
        //        return filter == null ?
        //              context.Set<Car>().ToList() :
        //              context.Set<Car>().Where(filter).ToList();
        //    }
        //}

        //public void Update(Car entity)
        //{
        //    using (CarMarketContext context = new CarMarketContext())
        //    {
        //        var updatedEntity = context.Entry(entity);
        //        updatedEntity.State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarMarketContext context =new CarMarketContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join col in context.Colors on c.ColorId equals col.ColorId
                             select new CarDetailDto()
                             {
                                 BrandName = b.BrandName,
                                 Description = c.Description,
                                 ColorName = col.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Id = c.Id
                             };

                return result.ToList();
            }
        }
    }
}
