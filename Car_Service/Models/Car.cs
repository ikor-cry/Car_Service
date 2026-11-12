using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Service.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string GosNuber { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int YearCreate { get; set; }
        public string ClientId { get; set; }
        public Client Client { get; set; }
        public string VIN { get; set; }
        
        public ICollection<Appointment> Appointments { get; set; }
    }
}
