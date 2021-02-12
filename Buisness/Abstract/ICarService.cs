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

        IDataResult<List<CarDetailDto>> GetCarDetail();
       
    }
}
