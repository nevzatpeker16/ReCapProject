using Buisness.Abstract;
using Buisness.Constants;
using Buisness.ValidationRules;
using Core.Aspect.Autofac.Validation;
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
        [ValidationAspect(typeof(BrandValidator))]

        public IDataResult<List<Brand>> GetBrands()
        {

            return new SuccessDataResult<List<Brand>>(_brandDal.getAll(),true, Messages.Listed);
            
        }
        [ValidationAspect(typeof(BrandValidator))]
        public IResult AddBrand (Brand brand)
        {
             _brandDal.Add(brand);
            return new SuccessResult(Messages.Added);
        }
        [ValidationAspect(typeof(BrandValidator))]
        public IResult UpdateBrand(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.Updated);
        }
        [ValidationAspect(typeof(BrandValidator))]
        public IResult DeleteBrand(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.Deleted);
        }

    }
}
