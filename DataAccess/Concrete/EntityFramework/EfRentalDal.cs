using Core.DataAccess.EntiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, DBContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (DBContext context = new DBContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.Id
                             join cu in context.Customers on r.CustomerId equals cu.Id
                             join b in context.Brands on c.BrandId equals b.Id
                             join cl in context.Colors on c.ColorId equals cl.Id
                             join u in context.Users on cu.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarBrandName = b.Name,
                                 CarColorName = cl.Name,
                                 CarDescription = c.Description,
                                 CarModelYear = c.ModelYear,
                                 CustomerFirstName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 CustomerEmail = u.Email,
                                 RentDate = r.RentDate,
                                 ReturnDate = (DateTime)r.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
