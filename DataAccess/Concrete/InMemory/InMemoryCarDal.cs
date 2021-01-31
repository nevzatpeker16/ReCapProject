using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarID=1,ColorID=1,BrandID=1,DailyPrice=150000,ModelYear=2021,Description="Audi A4 Quattro"},
                new Car{CarID=2,ColorID=1,BrandID=2,DailyPrice=100000,ModelYear=2021,Description="Ford Mustang GT"},
                new Car{CarID=3,ColorID=2,BrandID=1,DailyPrice=350000,ModelYear=2020,Description="Audi RS6"},
                new Car{CarID=4,ColorID=3,BrandID=3,DailyPrice=300000,ModelYear=2021,Description="BMW İ9"},
               
            };
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void DeleteCar(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            //LINQ Kullanarak silinecek arabanın id sinin, _cars listesinde olup olmadığını aradık.
            _cars.Remove(carToDelete);
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public List<Car> GetCarsByBrand(int BrandID)
        {
            return _cars.Where(c => c.BrandID == BrandID).ToList();
        }

        public List<Car> GetCarsByColor(int ColorID)
        {
            return _cars.Where(c => c.ColorID == ColorID).ToList();
        }

        public List<Car> GetCarsByModelYear(int ModelYear)
        {
            return _cars.Where(c => c.ModelYear == ModelYear).ToList();
        }

        public void UpdateCar(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.CarID = car.CarID;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
