using ProductOFSystem.Model.Model.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductOFSystem.Model.Model.Data
{
    public class Orders : BaseModel
    {
        public int? OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? RiderId { get; set; }
        public string Items { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Profit { get; set; }
    }
}
