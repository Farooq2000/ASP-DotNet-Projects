using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS.Model
{
    public class ApiResponse
    {
        public ApiResponse()
        {
            status = 0;
            Message = "Success";
        } 
        public int status { get; set; }
        public string Message { get; set; }
        public object Response { get; set; }
    }
}
