using Buisness.Abstract;
using Buisness.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public class BrandManager : IBrandService

        //Referance injection yaptık , IBrandDal ı kullanan bütün Data Access Layer lar erişebilecek buraya.
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetBrands()
        {

            return new SuccessDataResult<List<Brand>>(_brandDal.getAll(),true, Messages.Listed);
            
        }

        public IResult AddBrand (Brand brand)
        {
             _brandDal.Add(brand);
            return new SuccessResult(Messages.Added);
        }
        public IResult UpdateBrand(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.Updated);
        }
        public IResult DeleteBrand(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.Deleted);
        }

    }
}
