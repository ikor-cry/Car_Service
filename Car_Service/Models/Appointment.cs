using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Service.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public string Number { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public DateOnly DateAppointment { get; set; }
        public DateTime Time { get; set; }
        public string Master {  get; set; }
        public string Status { get; set; }
        public int Cost { get; set; }

    }
}
