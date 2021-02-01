using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("CarId:"+ car.CarId + " BrandId:" + car.BrandId + " ColorId:" +car.ColorId + " Model:" +car.ModelYear  + " Description:" +  car.Description + " Ücret=" + car.DailyPrice + " $ ");
            }
        }
    }
}
