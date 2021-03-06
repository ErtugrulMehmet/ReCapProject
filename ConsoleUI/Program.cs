using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductTest();

        }

            private static void ProductTest()
            {
                CarManager carManager = new CarManager(new EfCarDal());

                foreach (var car in carManager.GetCarDetails())
                {
                Console.WriteLine("{0} / {1} / {2} ",car.BrandName ,car.ColorName,car.DailyPrice );
                }
            }
    }
}
