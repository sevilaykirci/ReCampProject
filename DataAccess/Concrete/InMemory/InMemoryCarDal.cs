using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
            _cars = new List<Car>{
             //new Car{Id=1, BrandId=1 ,ColorId= 1 , DailyPrice=140, Description="sifir", ModelYear=2021},
             //new Car{Id = "2", BrandId = "2", ColorId = "2", DailyPrice = 170, Description = "sifir", ModelYear = 2021 },
             //new Car{Id="3", BrandId="1" ,ColorId= "4" , DailyPrice=150, Description="sifir", ModelYear=2021},
             //new Car{Id="4", BrandId="3" ,ColorId= "5" , DailyPrice=140, Description="sifir", ModelYear=2021},
             //new Car{Id="5", BrandId="4" ,ColorId= "1" , DailyPrice=70, Description="ikinci el", ModelYear=2021},
             //new Car{Id="6", BrandId="3" ,ColorId= "3" , DailyPrice=80, Description="ikinci el", ModelYear=2021}
        };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car DeleteToCar = _cars.SingleOrDefault(c => c.Id == car.Id);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id) 
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car UpdateToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            UpdateToCar.Id = car.Id;
            UpdateToCar.BrandId = car.BrandId;
            UpdateToCar.ColorId = car.ColorId;
            UpdateToCar.DailyPrice = car.DailyPrice;
            UpdateToCar.Description = car.Description;
            UpdateToCar.ModelYear = car.ModelYear;
        }
    }
}