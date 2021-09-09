using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _branddal;

        public BrandManager(IBrandDal branddal)
        {
            _branddal = branddal;
        }

        public void Add(Brand brand)
        {

            _branddal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _branddal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _branddal.GetAll();
        }

        public List<Brand> GetById(int id)
        {
            return _branddal.GetAll(b=>b.BrandId==id);
        }

        public void Update(Brand brand)
        {
            _branddal.Update(brand);
        }
    }
}
