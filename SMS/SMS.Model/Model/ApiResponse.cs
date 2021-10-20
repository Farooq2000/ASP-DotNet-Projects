using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Model
{
    public class ApiResponse
    {
        public ApiResponse()
        {
            Status = 0;
            Message = "Success";
        }
        public int Status { get; set; }
        public string Message { get; set; }
        public object Response { get; set; }

    }
}
