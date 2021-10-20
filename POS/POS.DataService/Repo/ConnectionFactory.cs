using POS.DataService.IRepo;
using POS.Model.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Z.Dapper.Plus;

namespace POS.DataService.Repo
{
    public class ConnectionFactory:IConnectionRepo
    {
        public string ConnectionString {get
            {
                //return "Data Source=DESKTOP-IDP8D9S;Initial Catalog=POS;User ID=farooq;Password=farooq123++";
                return "Data Source=DESKTOP-IDP8D9S;Initial Catalog=POS;User ID=farooq;Password=farooq123++";


            }


        }
          public ConnectionFactory()
            {
                DapperPlusManager.Entity<Orders>().Table("Orders").Identity(x => x.OrderId);

            }
        
    }
}
