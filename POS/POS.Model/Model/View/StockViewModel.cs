using POS.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Model.Model.View
{
    public class StockViewModel
    {
        public decimal TotalStockNetPrice { get; set; }
        public decimal TotalStockRetailPrice { get; set; }
        public List<Product> productList { get; set; }

    }
}
