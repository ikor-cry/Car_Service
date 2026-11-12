using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Service.Models
{
    public class Client
    {
        public string ClientId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateOnly DateOnReg { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
