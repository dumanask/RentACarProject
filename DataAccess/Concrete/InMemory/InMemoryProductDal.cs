using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _products;
        public InMemoryProductDal()
        {
            _products = new List<Car>
            {
                new Car{ BrandId=1, ColorId=1, DailyPrice=50000, Description ="Hundai", ModelYear=2010, CarId =1},
                new Car{ BrandId=1, ColorId=2, DailyPrice=60000, Description ="Hundai", ModelYear=2015, CarId =2},
                new Car{ BrandId=2, ColorId=2, DailyPrice=80000, Description ="Honda", ModelYear=2016, CarId =3},
                new Car{ BrandId=3, ColorId=4, DailyPrice=150000, Description ="Audi", ModelYear=2014, CarId =4},
                new Car{ BrandId=4, ColorId=1, DailyPrice=120000, Description ="Opel", ModelYear=2016, CarId =5},
            };
        }

        public int ProductId { get; private set; }

        public void Add(Car product)
        {
            _products.Add(product);
        }

        public void Delete(Car product)
        {
            Car productToDelete = _products.SingleOrDefault(p => p.CarId == product.CarId);

            _products.Remove(productToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _products;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int ProductId)
        {
            return _products.Where(p => p.CarId == ProductId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car product)
        {
            Car productToUpdate = _products.SingleOrDefault(p => p.CarId == product.CarId);

            productToUpdate.CarId = product.CarId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.Description = product.Description;
            productToUpdate.ModelYear = product.ModelYear;
        }
    }
}
