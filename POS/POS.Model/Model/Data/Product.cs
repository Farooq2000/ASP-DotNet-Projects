using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS.Model.Data
{
    public class Product:BaseModel
    {
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Pieces { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? WholeSellerPrice { get; set; }
        
        public decimal? RetailPrice { get; set; }
        public string ManufactedBy { get; set; }
        public string ManufactureDate { get; set; }
        public string ExpiryDate { get; set; }
        public decimal Discount { get; set; }
        public int? Stock { get; set; }

    }
}
