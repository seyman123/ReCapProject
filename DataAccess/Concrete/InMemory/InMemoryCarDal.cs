﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 250, Description = "Hatchback", ModelYear = 2009},
                new Car { Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 300, Description = "Sedan", ModelYear = 2013},
                new Car { Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 450, Description = "SUV", ModelYear = 2019},
                new Car { Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 350, Description = "Hatcback", ModelYear = 2020},
                new Car { Id = 5, BrandId = 2, ColorId = 2, DailyPrice = 550, Description = "Sedan", ModelYear = 2017},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
