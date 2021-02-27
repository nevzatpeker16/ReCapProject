using Buisness.Abstract;
using Buisness.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buisness.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult AddCarImage(CarImage carImage)
        {
            if(carImage.ImagePath == null)
            {

                carImage.ImagePath = "Deneme Yolu";
            }
            int carID = carImage.CarID;
            int ımageCount = ListImagesByCarID(carID).Data.Count();
            if(ımageCount <= 5)
            {
                carImage.Date = DateTime.Now.Date;
                _carImageDal.Add(carImage);
                return new SuccessResult(Messages.Added);

            }
            else
            {
                return new ErorResult(Messages.toMuchPhoto);
            }


         
        }

        public IResult DeleteCarImage(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CarImage>> ListImages()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.getAll(), Messages.Listed);
        }

        public IDataResult<List<CarImage>> ListImagesByCarID(int carID)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.getAll(c => c.CarID == carID),Messages.Listed);
        }

        public IResult UpdateCarImage(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.Updated);
        }
    }
}
