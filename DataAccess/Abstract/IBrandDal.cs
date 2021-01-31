using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal
    {
        void AddBrand(Brand brand);
        void DeleteBrand(Brand brand);
        void UpdateBrand(Brand brand);

        List<Brand> GetBrands();

        List<Brand> GetBrandByID(int BrandID);

    }
}
