using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
          List<Car> GetCarsByBrandId(int ıd);
        void Add(Car car);
          List<Car> GetCarsByColorId(int ıd);
        List<Car> GetAll();
        void deleted(Car car);
       List<GetCars> Gett();



    }
}
