using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=101,BrandId=201,ColorId=1,ModelYear=2015,DailyPrice=900.000,Description="Araç Açıklaması = Mercedes"},
                new Car{CarId=102,BrandId=202,ColorId=2,ModelYear=2018,DailyPrice=2500.000,Description="Araç Açıklaması = AstonMartin"},
                new Car{CarId=103,BrandId=203,ColorId=3,ModelYear=2019,DailyPrice=700.000,Description="Araç Açıklaması = VOLVO"},
                new Car{CarId=104,BrandId=204,ColorId=4,ModelYear=2021,DailyPrice=800.000,Description="Araç Açıklaması = MACLAREN"},
                new Car{CarId=105,BrandId=205,ColorId=5,ModelYear=2017,DailyPrice=600.000,Description="Araç Açıklaması = LAMBORGHİNİ"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllCategory(int CategoryId)
        {
            return (List<Car>)_cars.Where(c => c.CarId == CategoryId);
        }

        public void Update(Car car)
        {
            List<Car> _car1 = _cars;
            Car carToUpdate = _car1.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
