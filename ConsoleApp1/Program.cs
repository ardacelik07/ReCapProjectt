using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleIU2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            ICarManager carManager = new ICarManager(new EntityFrameworkCarDal());

          IBrandManager brandManager = new IBrandManager(new IEntityFrameworkBrandDal())







            foreach (var item in carManager.Gett())
            {

               Console.WriteLine(item.CarName+ "  " + item.BrandName+" " + item.DailyPrice+ " "+item.ColorName);

         }



        }
    }
}
