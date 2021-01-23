using System;

namespace RegistrationApp.Core.Model
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Created { get; set; }

        public Order()
        {
            OrderId = Guid.NewGuid();
            Created = DateTimeOffset.Now;
        }
    }
}
