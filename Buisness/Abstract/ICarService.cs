using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetCars();

        IDataResult<List<Car>> GetCarsByModelYear(int modelYear);
        IDataResult<Car> GetCarsByCarID(int carID);

        IDataResult<List<CarDetailDto>> GetCarDetail(int carID);

        IResult AddCar(Car car);

        IResult DeleteCar(Car car);
        IResult UpdateCar(Car car);
        IDataResult<List<Car>> GetCarsByColorID(int colorID);


    }
}
