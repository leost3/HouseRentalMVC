using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApartmentRentalSystem.Models.Apartment
{
    public class Apartment
    {
        [Key]
        public int Id{ get; set; }
        public String Address{ get; set; }
        public int Rooms { get; set; }
        public int Bathrooms { get; set; }
        public string ImgUrl { get; set; }
        public double RentPrice{ get; set; }

    }
}
