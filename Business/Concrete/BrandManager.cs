using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
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

        [ValidationAspect(typeof(BrandValidator))]
        public Result Add(Brand brand)
        {
            _branddal.Add(brand);
            return new SuccessResult();
        }

        public Result Delete(Brand brand)
        {
            _branddal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_branddal.GetAll());
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_branddal.Get(b=>b.BrandId==id));
        }

        public Result Update(Brand brand)
        {
            _branddal.Update(brand);
            return new SuccessResult();
        }
    }
}
