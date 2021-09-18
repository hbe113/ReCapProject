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
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from  c in context.Cars
                              join b in context.Brands
                              on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             //join cı in context.CarImages 
                             //on c.CarId equals cı.CarId
                             select new CarDetailDto 
                             { CarName = c.CarName, 
                                 BrandName = b.BrandName, 
                                 ColorName = co.ColorName, 
                                 DailyPrice = c.DailyPrice,
                                 ImagePath= (from i in context.CarImages where i.CarId == c.CarId select i.ImagePath).ToList()
                             };
                
                return result.ToList();
            }
        }
    }
}