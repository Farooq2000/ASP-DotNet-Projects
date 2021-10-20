using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Model.Model.Data
{
    public class Users:BaseModel
    {
        public int? UserId { get; set; }
        public int? EntityId { get; set; }
        public int? UserRoleId { get; set; }
        public string Email { get; set; }
        public string CNIC { get; set; }
        public string Password { get; set; }
        
    }
}
