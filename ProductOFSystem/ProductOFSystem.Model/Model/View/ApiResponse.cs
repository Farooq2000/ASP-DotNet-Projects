using System;
using System.Collections.Generic;
using System.Text;

namespace ProductOFSystem.Model.Model.View
{
    public class ApiResponse
    {
        public ApiResponse()
        {
            status = 0;
            Message = "success";
        }
        public int status { get; set; }
        public string Message { get;set;}
        public object Response { get; set; }
    }
}
