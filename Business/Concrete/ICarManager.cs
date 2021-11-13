using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ICarManager : ICarService
    {
        
        ICarDal _ICarDal;
        public ICarManager(ICarDal ICarDal)
        {
            _ICarDal = ICarDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _ICarDal.Add(car);
            }
            else
            {
                Console.WriteLine(" arabanın gunluk bir fiyatı olmalıdır");
            }
        }

        public void deleted(Car car)
        {
            _ICarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _ICarDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int ıd)
        {
            return _ICarDal.GetAll(p => p.BrandId == ıd);
        }

        public List<Car> GetCarsByColorId(int ıd)
        {
            throw new NotImplementedException();
        }

        public List<GetCars> Gett()
        {
           return _ICarDal.GetCars();
        }
    }
}

    
