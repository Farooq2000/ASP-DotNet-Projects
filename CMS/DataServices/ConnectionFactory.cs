using DataServices.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataServices
{
    public class ConnectionFactory : IConnectionRepo
    {
        public string ConnectionString
        {
            get
            {
                return "Data Source=DESKTOP-IDP8D9S;Initial Catalog=CMS;User ID=farooq;Password=farooq123++";
                //return  "Data Source = DESKTOP - IDP8D9S; Initial Catalog = CMS ; Integrated Security = True";
            }
        }
    }
}
//"Data Source=DESKTOP-MN4HF7F\\SQLEXPRESS;Initial Catalog=Pos;User ID=sa123;Password=12345678"