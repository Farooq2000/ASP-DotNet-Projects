using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Model.Model.Data
{
    public class Customer : BaseModel
    {
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int CustomerType { get; set; }
        public string Contact { get; set; }
        public string ShopName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string zip { get; set; }
        public string Email { get; set; }
    }
}

