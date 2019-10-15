using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApartmentRentalSystem.Models.Apartment
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageSubject { get; set; }
        public string MesssageBody { get; set; }
    }
}
