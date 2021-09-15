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
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand1 = new Brand();
            brand1.BrandId = 5;
            brand1.BrandName = "Dacia";
            brandManager.Add(brand1);
            Color color1 = new Color();
            color1.ColorId = 4;
            color1.ColorName = "Yeşil";
            colorManager.Add(color1);
            Car car1 = new Car();
            car1.CarId = 6;
            car1.BrandId = 3;
            car1.ColorId = 2;
            car1.ModelYear = 2013;
            car1.DailyPrice = 120;
            car1.Description = "Benzin";
            Car car2 = new Car();
            car2.CarId = 5;
            car2.BrandId = 3;
            car2.ColorId = 2;
            car2.ModelYear = 2013;
            car2.DailyPrice = 100;
            car2.Description = "Benzin";
         
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} {1} {2} {3}", car.CarName , car.BrandName ,car.ColorName ,car.DailyPrice );
            }
        }

        
    }
}
