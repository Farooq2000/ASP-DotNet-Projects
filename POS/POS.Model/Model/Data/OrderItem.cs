using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Model.Model.Data
{
    public class OrderItem
    {
        public int? CustomerId { get; set; }
        public int? OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Amount { get; set; }
        public int ProductQuantity { get; set; }
        public decimal TotalAmount { get; set; }
        
    }
}
