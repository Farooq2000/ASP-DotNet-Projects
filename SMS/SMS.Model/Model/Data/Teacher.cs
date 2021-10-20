using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Model.Model.Data
{
    public class Teacher:BaseModel
    {
        public int? TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string CNIC { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string DOB { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int? DeptId { get; set; }
        public string Courses { get; set; }
        public int? FatherId { get; set; }
    }
}
