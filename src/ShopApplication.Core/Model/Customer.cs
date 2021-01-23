using System.Collections.Generic;

namespace RegistrationApp.Core.Model
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string UserName { get; set; }
        public string VatNumber { get; set; }
        public decimal TotalGross { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}
