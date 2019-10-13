using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HouseRentalMVC.Models
{
    public class House
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public int Rooms { get; set; }
        public int Bathrooms { get; set; }
        public string imageUrl { get; set; }
    }
}
