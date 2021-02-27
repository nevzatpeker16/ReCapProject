using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> ListImages();
        IResult AddCarImage(IFormFile file,CarImage carImage);
        IResult DeleteCarImage(CarImage carImage);
        IResult UpdateCarImage(IFormFile file,CarImage carImage);
        IDataResult<List<CarImage>> ListImagesByCarID(int carID);
    }
}
