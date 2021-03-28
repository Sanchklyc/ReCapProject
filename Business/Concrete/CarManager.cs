﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
            if (car.Description.Length < 2)
            {
                Console.WriteLine("Araba eklenemedi. Açıklama 2 karakterden uzun olmalıdır.");
                return;
            }
            if(car.DailyPrice <= 0)
            {
                Console.WriteLine("Araba eklenemedi. Günlük fiyat 0'dan büyük olmalıdır.");
                return;
            }
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _carDal.GetCarsByBrandId(brandId);
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _carDal.GetCarsByColorId(colorId);
        }

        public Car GetById(int carId)
        {
            return _carDal.GetById(carId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
