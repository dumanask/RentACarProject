using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarsContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarsContext context = new CarsContext())
            {
                var rentResult = from r in context.Rentals
                                 join p in context.Cars
                                 on r.CarId equals p.CarId
                                 join u in context.Users
                                 on r.UserId equals u.UserId
                                 join cu in context.Customers
                                 on r.CustomerId equals cu.CustomerId
                                 select new RentalDetailDto
                                 {
                                     CarId = p.CarId,
                                     UserId = u.UserId,
                                     CustomerId = cu.CustomerId
                                 };
                                 return rentResult.ToList();

            }
        }
    }
}
