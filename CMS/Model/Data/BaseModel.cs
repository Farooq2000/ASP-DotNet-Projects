using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Data
{
    public class BaseModel
    {
        public BaseModel()
        {
            InsertedOn = DateTime.Now.ToString("01/01/1990 01:01");
            DeletedOn = DateTime.Now.ToString("01/01/1990 01:01");
            UpdatedOn = DateTime.Now.ToString("01/01/1990 01:01");
            IsDelete = false;
        }
        public bool IsDelete { get; set; }
        public int DeletedBy { get; set; }
        public string DeletedOn { get; set; }
        public int InsertedBy { get; set; }
        public string InsertedOn { get; set; }
        public int UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        
        
    }
}
