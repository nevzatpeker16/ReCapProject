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
            return _brandDal.getAll();
            
        }

        public void AddBrand (Brand brand)
        {
             _brandDal.Add(brand);
        }
        public void UpdateBrand(Brand brand)
        {
            _brandDal.Update(brand);
        }
        public void DeleteBrand(Brand brand)
        {
            _brandDal.Delete(brand);
        }

    }
}
