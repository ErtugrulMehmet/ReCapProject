using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1,BrandId=1,ColorId=1,DailyPrice=1000,Description="BMW 3.20",ModelYear=2010},
                new Car {CarId=2,BrandId=1,ColorId=2,DailyPrice=2000,Description="BMW 3.30",ModelYear=2012},
                new Car {CarId=3,BrandId=2,ColorId=1,DailyPrice=3000,Description="Mercedes AMG",ModelYear=2019},
                new Car {CarId=4,BrandId=2,ColorId=3,DailyPrice=15000,Description="Mercedes GLA",ModelYear=2002},
                new Car {CarId=5,BrandId=3,ColorId=1,DailyPrice=1300,Description="Honda Civic",ModelYear=2008},
                new Car {CarId=6,BrandId=3,ColorId=3,DailyPrice=5200,Description="Honda Accord",ModelYear=2021}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

       

        public List<Car> GetAll()
        {
            return _cars;
        }

        

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.Description = car.Description;

        }

        

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.CarId == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
