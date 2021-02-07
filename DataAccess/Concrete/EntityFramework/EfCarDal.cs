using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,MyDbContext>,ICarDal
    {
        public EfCarDal()
        {
        }

        public List<CarDetailDto> GetCarDetail()
        {
            using(MyDbContext myDbContext =  new MyDbContext())
            {
                var result = from cd in myDbContext.Cars
                             join cl in myDbContext.Colors on cd.ColorID equals cl.ColorID
                             join br in myDbContext.Brands on cd.BrandID equals br.BrandID
                             select new CarDetailDto {   CarID = cd.CarID , 
                                                         Description = cd.Description ,
                                                         BrandName = br.BrandName ,
                                                         ColorName = cl.ColorName ,
                                                         ModelYear = cd.ModelYear ,
                                                         DailyPrice = cd.DailyPrice  };

                return result.ToList();

            }
        }
        //EfEntityRepositoryBase den artık kullanılabilir bu işlemler gerek kalmadı o yüzden...
        //public void Add(Car entity)
        //{
        //    using (MyDbContext myDbContext = new MyDbContext())
        //    {
        //        var addedEntity = myDbContext.Entry(entity);
        //        addedEntity.State = EntityState.Added;
        //        myDbContext.SaveChanges();

        //    }
        //}

        //public void Delete(Car entity)
        //{
        //    using (MyDbContext myDbContext = new MyDbContext())
        //    {
        //        var deletedEntity = myDbContext.Entry(entity);
        //        deletedEntity.State = EntityState.Deleted;
        //        myDbContext.SaveChanges();
        //    }
        //}

        //public Car Get(Expression<Func<Car, bool>> filter)
        //{
        //    using (MyDbContext myDbContext = new MyDbContext())
        //    {
        //        return myDbContext.Set<Car>().SingleOrDefault(filter);

        //    }
        //}

        //public List<Car> getAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    using (MyDbContext myDbContext = new MyDbContext())
        //    {
        //        return filter == null ? myDbContext.Set<Car>().ToList() : myDbContext.Set<Car>().Where(filter).ToList();


        //    }
        //}

        //public void Update(Car entity)
        //{
        //    using (MyDbContext myDbContext = new MyDbContext())
        //    {
        //        var updatedEntity = myDbContext.Entry(entity);
        //        updatedEntity.State = EntityState.Modified;
        //        myDbContext.SaveChanges();


        //    }
        //}
    }
}
