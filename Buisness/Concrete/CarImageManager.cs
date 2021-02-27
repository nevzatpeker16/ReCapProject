using Buisness.Abstract;
using Buisness.Constants;
using Buisness.ValidationRules;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
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
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult AddCarImage(IFormFile formFile,CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckCarImageCount(carImage.CarID), CheckIfNullImage(carImage));
            if (result.Success) { 
                carImage.Date = DateTime.Now.Date;
                _carImageDal.Add(carImage);
                return new SuccessResult(Messages.Added);
            }
            else
            {
                return new ErorResult(Messages.eror);
            }
           
         
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult DeleteCarImage(CarImage carImage)
        {
            var path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _carImageDal.Get(cı => cı.ImageID == carImage.ImageID).ImagePath;
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.Deleted);
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<List<CarImage>> ListImages()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.getAll(), Messages.Listed);
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<List<CarImage>> ListImagesByCarID(int carID)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.getAll(c => c.CarID == carID),Messages.Listed);
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult UpdateCarImage(IFormFile formFile,CarImage carImage)
        {
            var oldpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _carImageDal.Get(p => p.ImageID == carImage.ImageID).ImagePath;
            carImage.ImagePath = FileHelper.UpdateAsync(oldpath, formFile);
            carImage.Date = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.Updated);
        }
        private IResult CheckCarImageCount(int CarID)
        {
            var result = _carImageDal.getAll(cı => cı.CarID == CarID).Count();
            if(result >= 5)
            {
                return new ErorResult(Messages.toMuchPhoto);

            }
            return new SuccessResult();
        }
        private IResult CheckIfNullImage(CarImage carImage)
        {
            if (carImage.ImagePath.Length == 0) {

                carImage.ImagePath = @"\Images\default.jpg";
            }
            return new SuccessResult();
        }
    }
}
