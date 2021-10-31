using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> getAll();
        void Add(Car car);
        void delete(Car car);
        List<Car> getbyıd(int CategoryId);

    }
}
