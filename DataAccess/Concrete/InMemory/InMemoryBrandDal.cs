using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand> { 
                new Brand {BrandID = 1 , BrandName = "Audi" },
                new Brand {BrandID = 2, BrandName = "Ford" }, 
                new Brand {BrandID = 3,BrandName = "BMW"}
                                        };
        }

        public void Add(Brand entity)
        {
            _brands.Add(entity);
        }



        public void Delete(Brand entity)
        {
            Brand brandToDelete = _brands.SingleOrDefault(c => c.BrandID == entity.BrandID);
            _brands.Remove(brandToDelete);
        }



        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> getAll(Expression<Func<Brand, bool>> filter = null)
        {
            return _brands;
        }

        public void Update(Brand entity)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.BrandID == entity.BrandID);
            brandToUpdate.BrandID = entity.BrandID;
            brandToUpdate.BrandName = entity.BrandName;
        }
    }
}
