using POS.Model.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Model.Model.View
{
    public class BaseFilter 
    {
        public int? OrderId { get; set; } 
        public string CustomerName { get; set; }
        public int? CustomerId { get; set; }
        public string Address { get; set; }
        public string ShopName { get; set; }
        public string DeliveryTime { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
        public string Contact { get; set; }
        public string State { get; set; }
        public string Items { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
