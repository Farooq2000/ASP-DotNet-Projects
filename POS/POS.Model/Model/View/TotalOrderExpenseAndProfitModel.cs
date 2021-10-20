using POS.Model.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Model.Model.View
{
    public class TotalOrderExpenseAndProfitModel
    {
        public List<Orders> OrderList { get; set; }
        public decimal TotalCostPrice { get; set; }
        public decimal TotalProfit { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
