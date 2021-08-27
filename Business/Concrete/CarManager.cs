using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;


        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length >= 2)
            {
                _carDal.Add(car); 
            }
            else
            {
                Console.WriteLine("Ekleme İşlemi Tamamlanamadı.Araba günlük fiyatı 0'dan büyük olmalı ve araba ismi minimum 2 karakter olmalı. Lütfen bilgileri kontrol ederek tekrar deneyiniz");
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public Car Get(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();    
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(c => c.CarId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        /*   public List<Car> GetCarsByBrandId(int id)
           {
               return _carDal.GetAll(c => c.BrandId == id);
           }*/

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        
    }
}
