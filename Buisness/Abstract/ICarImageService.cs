using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> ListImages();

        IResult AddCarImage(CarImage carImage);
        IResult DeleteCarImage(CarImage carImage);
        IResult UpdateCarImage(CarImage carImage);

        IDataResult<List<CarImage>> ListImagesByCarID(int carID);
    }
}
