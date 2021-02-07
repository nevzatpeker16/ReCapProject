using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface ICarService
    {
        List<Car> GetCars();

        List<Car> GetCarsByModelYear(int modelYear);

        List<CarDetailDto> GetCarDetail();
    }
}
