using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Data
{
    public class Father : BaseModel
    {
        public int FatherID { get; set; }
        public string FatrherName { get; set; }
        public string CNIC { get; set; }
        public string Occupation { get; set; }
        public string Contact { get; set; }
    }
}
