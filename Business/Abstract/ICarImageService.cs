using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);
        Result Add(IFormFile file,CarImage carImage);
        Result Update(IFormFile file, CarImage carImage);
        Result Delete(CarImage carImage);
    }
}
