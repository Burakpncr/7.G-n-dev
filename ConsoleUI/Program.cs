using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
           
            Car car1 = new Car();
            car1.CarId = 1;
            car1.BrandId = 1;
            car1.ColorId = 2;
            car1.ModelYear = 2013;
            car1.DailyPrice = 120;
            car1.Description = "Benzin";
            Brand brand4 = new Brand();
            brand4.BrandId = 4;
            brand4.BrandName = "Fiat";
            Color color4 = new Color();
            color4.ColorId = 4;
            color4.ColorName = "Kırmızı";
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
           foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} {1} {2} {3}" ,car.CarName, car.BrandName, car.ColorName,car.DailyPrice);
            } 

        }

        
    }
}
