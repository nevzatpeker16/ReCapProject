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
    public class EfColorDal : IColorDal
    {
        public EfColorDal()
        {
        }

        public void Add(Color entity)
        {
              using (MyDbContext myDbContext = new MyDbContext())
            {
                var addedEntity = myDbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                myDbContext.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using(MyDbContext myDbContext = new MyDbContext())
            {
                var deletedEntity = myDbContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                myDbContext.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                return myDbContext.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> getAll(Expression<Func<Color, bool>> filter = null)
        {
            using (MyDbContext myDbContext = new MyDbContext()) {
                return filter == null ? myDbContext.Set<Color>().ToList() : myDbContext.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
                using (MyDbContext myDbContext = new MyDbContext())
            {
                var updatedEntity = myDbContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                myDbContext.SaveChanges();

            }
        }
    }
}
