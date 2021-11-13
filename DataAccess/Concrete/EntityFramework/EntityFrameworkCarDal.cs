using CORE.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EntityFrameworkCarDal : EfEntityRepositoryBase<Car, ReCapProjectcontext>, ICarDal
    {
        

        public List<GetCars> GetCars()
        {
            using(ReCapProjectcontext context=new ReCapProjectcontext())
            {

                var result = from p in context.Car
                             join c in context.Brand

                             on
                             p.BrandId equals c.Id
                             join t in context.color on
                             p.ColorId equals t.Id
                             select new GetCars { CarName = p.Description, DailyPrice = p.DailyPrice, ColorName = t.Name, BrandName = c.Name };
                return result.ToList();





            }
        }
    }
}
