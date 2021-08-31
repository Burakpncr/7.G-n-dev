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
            Car car3 = new Car();
            car3.CarId = 6;
            car3.BrandId = 4;
            car3.ColorId = 2;
            car3.DailyPrice = 90;
            car3.Description = "Tüplü";
            car3.ModelYear = 2005;

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.CarId + " " + car.ColorId + " " + car.BrandId + " " + car.DailyPrice + " " + car.Description + " " + car.ModelYear);
            }
        }

        
    }
}
