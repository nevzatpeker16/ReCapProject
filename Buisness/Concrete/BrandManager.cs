using Buisness.Abstract;
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

        public List<Brand> GetBrands()
        {
            return _brandDal.GetBrands();
            
        }
    }
}
