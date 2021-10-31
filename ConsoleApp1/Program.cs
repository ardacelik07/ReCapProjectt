using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleIU2
{
    class Program
    {
        private static object incarManager;

        static void Main(string[] args)
        {
            ICarManager carManager = new ICarManager(new EntityFrameworkCarDal());
            Car car1 = new Car();
            car1.ModelYear = 2002;
            car1.Description = " fiesta";
            car1.DailyPrice = 699;
            car1.Id = 1;

       



            foreach (var item in carManager.getAll())
            {

                Console.WriteLine(item.Description);

            }



        }
    }
}
