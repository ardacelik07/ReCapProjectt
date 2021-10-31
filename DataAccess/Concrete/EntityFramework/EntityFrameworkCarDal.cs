using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public  class EntityFrameworkCarDal : ICarDal
    {
        List<Car> car2;
        public EntityFrameworkCarDal()
        {
            car2 = new List<Car> { 
            
              new Car{Description="ford"},
            
            
            };
            
           
                
        }
     
        public void Add(Car car)
        {
            
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return car2;
        }

        public List<Car> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
