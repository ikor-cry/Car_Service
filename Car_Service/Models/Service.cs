using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Service.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Duration { get; set; }
        public string Category { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

    }
}
