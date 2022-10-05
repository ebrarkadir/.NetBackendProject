using Core.DataAccess.EntiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDto()
        {
            using (DBContext context = new DBContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands on p.BrandId equals c.BrandId
                             join x in context.Colors on p.ColorId equals x.ColorId
                             select new CarDetailDto
                             {
                                 BrandName = c.BrandName,
                                 CarName = p.Description,
                                 ColorName = x.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
