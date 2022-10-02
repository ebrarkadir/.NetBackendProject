using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            if (entity.BrandName.Length > 2)
            {
                using (DBContext context = new DBContext())
                {
                    var addedEntity = context.Entry(entity);
                    addedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                    context.SaveChanges();
                }
            }
            else
            {
                Console.WriteLine("Araba ismi 2 karakterden fazla olmalıdır.");
            }
        }

        public void Delete(Brand entity)
        {
            using (DBContext context = new DBContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (DBContext context = new DBContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand,bool>>filter=null)
        {
            using (DBContext context = new DBContext())
            {
                return filter == null ? context.Set<Brand>().ToList()
                       : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (DBContext context = new DBContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
