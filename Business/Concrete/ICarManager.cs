using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
            if (car.ModelYear > 2000)
            {
                _ICarDal.Add(car);


            }
        }

        public void delete(Car car)
        {
            if (car.DailyPrice < 400)
            {
                _ICarDal.Delete(car);

            }
        }

        public List<Car> getAll()
        {
            // iş sınıfı
            return _ICarDal.GetAll();
        }

        public List<Car> getbyıd(int CategoryId) => _ICarDal.GetById(CategoryId);
    }

}
