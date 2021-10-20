using POS.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS.Model.View
{
    public class ProductView: Product
    {
        public int status { get; set; }
        public string Message { get; set; }
    }
}
