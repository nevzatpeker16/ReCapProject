using Buisness.Abstract;
using Buisness.Constants;
using Buisness.ValidationRules;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
        [ValidationAspect(typeof(CarValidator))]
        public IDataResult<List<Car>> GetCars()
        {
            return new SuccessDataResult<List<Car>>(_carDal.getAll(),Messages.Listed);  
        }
        [ValidationAspect(typeof(CarValidator))]
        public IDataResult<List<Car>> GetCarsByModelYear(int modelYear)
        {
            return new SuccessDataResult<List<Car>>(_carDal.getAll(p => p.ModelYear == modelYear),Messages.Listed);

        }
        [ValidationAspect(typeof(CarValidator))]
        public IDataResult<List<Car>> GetCarsByColorID(int colorID)
        {
            return new SuccessDataResult<List<Car>>( _carDal.getAll(p => p.ColorID == colorID),Messages.Listed);
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult AddCar(Car car)
        {

            if (car.Description.Length > 1)
            {
                if (car.DailyPrice > 0) { 
                        
                   _carDal.Add(car);
                    return new SuccessResult(Messages.Added);

                }
                else
                {
                    return new ErorResult("Araç fiyatı 0 dan büyük olmalıdır");

                }
            }
            else
            {
                return new ErorResult("Araç Adı 2 karakterden büyük olmalı.");
            }

            //Bu mesajları da constant olarak ekleyebilirdim aslında saat 23:22 olunca biraz kafa uğraşmak istemiyor bununla.
                


        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult DeleteCar(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult UpdateCar(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.Updated);
        }
        [ValidationAspect(typeof(CarValidator))]
        public IDataResult<List<CarDetailDto>> GetCarDetail(int carID)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail(carID),Messages.Listed);
        }
        [ValidationAspect(typeof(CarValidator))]
        public IDataResult<Car> GetCarsByCarID(int carID)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.CarID == carID), Messages.Listed);
        }
    }
}
