using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        void AddCar(Car car);
        void DeleteCar(Car car);
        void UpdateCar(Car car);

        List<Car> GetCars();
        List<Car> GetCarsByModelYear(int ModelYear);

        List<Car> GetCarsByColor(int ColorID);

        List<Car> GetCarsByBrand(int BrandID);

    }
}
