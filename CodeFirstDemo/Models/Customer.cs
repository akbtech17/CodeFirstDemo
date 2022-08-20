using System;

namespace CodeFirstDemo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
    public class Orders {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingName { get; set; }

    }
}
