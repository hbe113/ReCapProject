using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colormanager = new ColorManager(new EfColorDal());

            //Brand bmw = new Brand {BrandName="BMW" };
            //Brand mercedes = new Brand {BrandName="Mercedes" };
            //Brand volvo = new Brand {BrandName="Volvo" };
            //Brand peugeot = new Brand {BrandName="Peugeot" };
            //Brand audi = new Brand {BrandName="Audi" };

            //Color red = new Color { ColorName = "Red" };
            //Color black = new Color { ColorName = "Black" };
            //Color white = new Color { ColorName = "White" };
            //Color gray = new Color { ColorName = "Gray" };

            //Car car1 = new Car { BrandId=1, CarName="520i", ColorId=1, DailyPrice=350, ModelYear=new DateTime(2018), Description="Harika"};
            //Car car2 = new Car { BrandId = 2, CarName = "C180", ColorId = 2, DailyPrice = 400, ModelYear = new DateTime(2019), Description = "Harika" };
            //Car car3 = new Car { BrandId = 3, CarName = "S90", ColorId = 3, DailyPrice = 300, ModelYear = new DateTime(2016), Description = "Harika" };
            //Car car4 = new Car { BrandId = 4, CarName = "208", ColorId = 1, DailyPrice = 250, ModelYear = new DateTime(2015), Description = "Harika" };

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName);
            //}

            //foreach (var car in carManager.GetAll()) 
            //{
            //    Console.WriteLine(car.Description);
            //}
        }
    }
}
