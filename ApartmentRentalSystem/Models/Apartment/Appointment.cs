using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApartmentRentalSystem.Models.Apartment
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int ApartmentId { get; set; }
        public DateTime DateTime {get; set;}
    
    }
}
