using DataService.IRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Repo
{
    public class ConnectionFactory : IConnectionRepo
    {
        public String ConnectionString
        {
            get
            {
                return "Data Source=DESKTOP-IDP8D9S;Initial Catalog=POS;User ID=farooq;Password=farooq123++";
            }
        }
    }
}
