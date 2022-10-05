using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //GetAllColors(colorManager);
            //GetAllCars(carManager);
            //GetAllBrands(brandManager);

            carManager.Add(new Car { Id = 5, BrandId = 5, Description = "toyaota", ColorId = 1, DailyPrice = 110, ModelYear = 2008 });//Şartlara uymuyor

            //GetCarsByBrandID
                foreach (var car in carManager.GetCarsByBrandId(5))
            {
                System.Console.WriteLine("{0} --- {1}", car.Description, car.BrandId);
            }

            //GetCarsByColorID
            //foreach (var car in carManager.GetCarsByColorId(1))
            //{
            //    System.Console.WriteLine("{0} --- {1}", car.Description, car.ColorId);
            //}

        //}

        //////getallcolor
        //private static void GetAllColors(ColorManager colorManager)
        //{
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        System.Console.WriteLine(color.ColorName);
        //    }
        //}

        ////getallcars
        //private static void GetAllCars(CarManager carManager)
        //{
        //    foreach (var car in carManager.GetAll())
        //    {
        //        System.Console.WriteLine(car.Description);
        //    }
        //}

        ////getallBrands
        //private static void GetAllBrands(BrandManager brandManager)
        //{
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        System.Console.WriteLine(brand.BrandName);
        //    }

    }

    }
}
