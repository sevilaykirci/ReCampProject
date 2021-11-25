using DataAccess.Concrete.InMemory;
using Business.Concrete;
using System;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
          

            CarManager carManager = new CarManager(new EfCarDal());

            foreach ( var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);

            }
            
        }
    }
}
