
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleIU2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarManager carManager = new ICarManager(new InMemoryCarDal());

            foreach (var item in carManager.getAll())
            {

                Console.WriteLine(item.Description);

            }
        }
    }
}
