using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Model.Model.View
{
    public class ItemView 
    {
        public List<Items> items { get; set; }
    }

    public class Items
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Amount { get; set; }
        public int ProductQuantity { get; set; }
        public decimal TotalAmount { get; set; }
        
    }


}
