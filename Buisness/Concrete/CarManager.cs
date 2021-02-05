﻿using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public class CarManager : ICarService

    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetCars()
        {
            return _carDal.getAll();  
        }

        public List<Car> GetCarsByModelYear(int modelYear)
        {
            return _carDal.getAll(p => p.ModelYear == modelYear);

            //Yarın buradan devam et. 
        }
        public List<Car> GetCarsByColorID(int colorID)
        {
            return _carDal.getAll(p => p.ColorID == colorID);
        }
        public void AddCar(Car car)
        {

            if (car.Description.Length > 1)
            {
                if (car.DailyPrice > 0) { 
                        
                    _carDal.Add(car);

                }
                else
                {
                    throw new Exception("Araç günlük fiyatı 0 dan büyük olmalıdır.");

                }
            }
            else
            {
                throw new System.Exception("Araç Adı 2 Karakterden  kısa olamaz.");
            }
                


        }
    }
}
