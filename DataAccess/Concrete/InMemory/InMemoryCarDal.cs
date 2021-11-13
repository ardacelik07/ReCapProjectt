using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
      

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=200,Description=" CAMARO "},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2001,DailyPrice=500,Description=" lambo "},
                new Car{Id=3,BrandId=3,ColorId=2,ModelYear=2002,DailyPrice=300,Description=" doblo "},
                new Car{Id=4,BrandId=5,ColorId=3,ModelYear=2003,DailyPrice=700,Description=" bmw "},
                new Car{Id=5,BrandId=2,ColorId=4,ModelYear=2004,DailyPrice=900,Description=" mercedes "},


            };


        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = null;
            CarToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(CarToDelete);


        }

        public Car get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;

        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public List<GetCars> GetCars()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
          Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);

            
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
