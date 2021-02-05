using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public EfBrandDal()
        {
        }

        public void Add(Brand entity)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {


                var addedEntity = myDbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                //Durumunu eklenen'e çektik.
                myDbContext.SaveChanges();


            }
            
        }

        public void Delete(Brand entity)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                var deletedEntity = myDbContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                myDbContext.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using(MyDbContext myDbContext = new MyDbContext())
            {
                return myDbContext.Set<Brand>().SingleOrDefault(filter);

            }
        }

        public List<Brand> getAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {

                return filter == null ? myDbContext.Set<Brand>().ToList() : myDbContext.Set<Brand>().Where(filter).ToList();
                    //Soru işaretinden sonra ilk true olma durumu .
            }
        }

        public void Update(Brand entity)
        {
            using(MyDbContext myDbContext = new MyDbContext())
            {
                var updatedEntity = myDbContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                myDbContext.SaveChanges();

            }
        }
    }
}
