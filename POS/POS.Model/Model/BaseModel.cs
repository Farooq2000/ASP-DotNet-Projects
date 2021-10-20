using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS.Model
{
    public class BaseModel
    {
        public BaseModel()
        {
            InsertedOn = DateTime.Now.ToString("01/01/1900 01:01");
            DeletedOn = DateTime.Now.ToString("01/01/1900 01:01");
            UpdatedOn = DateTime.Now.ToString("01/01/1900 01:01");
        }
        public int IsDelete { set; get; }
        public string DeletedOn { set; get; }
        public int DeletedBy { set; get; }
        public string InsertedOn { set; get; }
        public int InsertedBy { set; get; }
        public string UpdatedOn { set; get; }
        public int UpdatedBy { set; get; }
    }
}
