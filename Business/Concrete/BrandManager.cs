using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void AddBrand(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
            }
            else
            {
                Console.WriteLine("Marka ismi için en az 2 karaker girilmeli.");
            }
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }
    }
}
