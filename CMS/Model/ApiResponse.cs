using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string  Message { get; set; }
        public object  Response { get; set; }//object mai sb ja sktai hai jason wagairah sb
    }
}
