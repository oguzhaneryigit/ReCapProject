using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //manager ve database oluşturma
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Listele(carManager);

            //silme işlemi
            carManager.Delete(new Car() { Id = 2 });
            Listele(carManager);

            //güncelleme
            carManager.Update(new Car() { Id = 1, Description = "nisan suv", BrandId = 1, ColorId = 10, DailyPrice = 15000, ModelYear="2015"}) ;
            Listele(carManager);

            //ekleme
            carManager.Add(new Car() { Id = 5, Description = "mercedes suv", BrandId = 1, ColorId = 10, DailyPrice = 15000, ModelYear = "2015" });
            Listele(carManager);
        }

        static void Listele(CarManager carManager)
        {
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine();
        }

    }
}
