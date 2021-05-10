using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto: IDto
    {

        public int UserId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
    }
}
