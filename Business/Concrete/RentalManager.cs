using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public Result Add(Rental rental)
        {
            if (rental.ReturnDate==null)
            {
                return new ErrorResult(Messages.CarIsNotReturn);
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarIsReturn);
        }

        public Result Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<Rental>> GetById(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.RentalId == id));
        }

        public Result Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
