using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand> { 
                new Brand {BrandID = 1 , BrandDescription = "Audi" },
                new Brand {BrandID = 2, BrandDescription = "Ford" }, 
                new Brand {BrandID = 3,BrandDescription = "BMW"}
                                        };
        }

        public void AddBrand(Brand brand)
        {
            _brands.Add(brand);
        }

        public void DeleteBrand(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(c => c.BrandID == brand.BrandID);
            _brands.Remove(brandToDelete);
        }

        public List<Brand> GetBrandByID(int BrandID)
        { 
            return _brands.Where(b => b.BrandID == BrandID).ToList();
        }

        public List<Brand> GetBrands()
        {
            return _brands;
        }

        public void UpdateBrand(Brand brand)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.BrandID == brand.BrandID);
            brandToUpdate.BrandID = brand.BrandID;
            brandToUpdate.BrandDescription = brand.BrandDescription;
        }
    }
}
