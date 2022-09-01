using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsolUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            inMemoryCarDal.Add(new Car { Id = 6, BrandId = 1, ColorId = 2, DailyPrice = 250, Description = "SUV", ModelYear = 2015 });
            
            Car car1 = new Car { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 400, Description = "SUV", ModelYear = 2016 };
            Car car2 = new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 300, Description = "Hatcback", ModelYear = 2009 };
            //inMemoryCarDal.Delete(car1);
            inMemoryCarDal.Update(car1);
            inMemoryCarDal.Update(car2);
            
            
            CarManager carManager = new CarManager(inMemoryCarDal);

            foreach (var car in carManager.GetAllCars())
            {
                Console.WriteLine(car.Id + " : " + car.Description + ": Fiyat : " + car.DailyPrice + " : " + car.ModelYear);
            }


            Console.WriteLine("\n\nMarkası 2 olan arabalar   : \n");
            foreach (var car in inMemoryCarDal.GetById(2))
            {
                Console.WriteLine(car.Id + " : " + car.Description + ": Fiyat : " + car.DailyPrice + " : " + car.ModelYear);
            }
        }
    }
}