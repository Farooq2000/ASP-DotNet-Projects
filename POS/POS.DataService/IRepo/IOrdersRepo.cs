using POS.Model;
using POS.Model.Data;
using POS.Model.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.IRepo
{
    public interface IOrdersRepo
    {
        public ApiResponse Create(Orders model);
        public ApiResponse Update(Orders model);
        public List<Orders> Search(Object model);
       
    }
}
