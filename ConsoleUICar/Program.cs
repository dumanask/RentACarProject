﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUICar
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();
            //CarTest();
            //ColorTest();

            //UserTest();
            //CustomerTest();
            RentalTest();

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            
            rentalManager.Add(new Rental {   RentDate = DateTime.Now });
            

            var rentalDtoResults = rentalManager.GetRentalDetails();
            if (rentalDtoResults.Success)
            {
                foreach (var rentalDetail in rentalDtoResults.Data)
                {
                    Console.WriteLine("{0} {1}  {2}  } ", rentalDetail.CustomerId);
                }
            }

            var rentalResult = rentalManager.GetAll();
            if (rentalResult.Success)
            {
                foreach (var rental in rentalResult.Data)
                {
                    Console.WriteLine("Car Id : {0}\nCustomer Id : {1}\nRent Date : {2}\nReturn Date: {3}\nMessage : {4}", rental.CarId, rental.CustomerId, rental.RentDate, rental.ReturnDate, rentalResult.Success);

                }
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            customerManager.Add(new Customer {CompanyName = "Yapı Kredi" });

            var customerResult = customerManager.GetAll();
            if (customerResult.Success)
            {
                foreach (var customer in customerResult.Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            
            userManager.Add(new User { FirstName = "Emir", LastName = "Duman",  Email = "askimemir96@gmail.com", Password = "emir1234" });
            
            var userResult = userManager.GetAll();
            if (userResult.Success)
            {
                foreach (var user in userResult.Data)
                {
                    Console.WriteLine(user.FirstName);
                }
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());


            //colorManager.Add(new Color { ColorId = 1, ColorName = "Kırmızı" });
            //colorManager.Add(new Color { ColorId = 2, ColorName = "Mavi" });
            //colorManager.Add(new Color { ColorId = 3, ColorName = "Yeşil" });



            var colorResult = colorManager.GetAll();
            if (colorResult.Success)
            {
                foreach (var color in colorResult.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { BrandId = 1, ColorId = 1, ModelYear = "Passat", UnitPrice = 200000, Description = "Marka Volkswagen, rengi kırmızı" });
            //carManager.Add(new Car { BrandId = 1, ColorId = 2, ModelYear = "Golf", UnitPrice = 130000, Description = "Marka Volksvagen, rengi mavi" });
            //carManager.Add(new Car { BrandId = 1, ColorId = 2, ModelYear = "Transporter", UnitPrice = 150000, Description = "Marka Volkswagen rengi mavi" });
            //carManager.Add(new Car { BrandId = 2, ColorId = 3, ModelYear = "Captur", UnitPrice = 212500, Description = "Marka Renault rengi yeşil" });
            //carManager.Add(new Car { BrandId = 2, ColorId = 3, ModelYear = "Symbol", UnitPrice = 141000, Description = "Marka Renault rengi yeşil" });
            //carManager.Add(new Car { BrandId = 2, ColorId = 1, ModelYear = "Clio", UnitPrice = 180000, Description = "Renk : Kırmızı Marka: Renault" });
            //carManager.Delete(new Car { Id = 8 });
            carManager.Update(new Car { CarId = 1, CarName = "Toyota" });

            var carResult = carManager.GetCarDetails();
            if (carResult.Success)
            {
                foreach (var car in carResult.Data)
                {
                    Console.WriteLine("Model: {0}\nMarka: {1}\nRenk: {2}\nFiyat: {3} ", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
                }
            }

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Volkswagen" });
            brandManager.Add(new Brand { BrandName = "Renault" });


            var brandResult = brandManager.GetAll();
            if (brandResult.Success)
            {
                foreach (var brand in brandResult.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }

        }
    }
}
