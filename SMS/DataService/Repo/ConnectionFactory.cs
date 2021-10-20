using DataService.IRepo;
using SMS.Model.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Z.Dapper.Plus;

namespace DataService.Repo
{
    public class ConnectionFactory : IConnectionRepo
    {
        public string ConnectionString { get
            {
                return "Data Source=DESKTOP-IDP8D9S;Initial Catalog=SMS;User ID=farooq;Password=farooq123++";
            }
        }
        public ConnectionFactory()
        {
            DapperPlusManager.Entity<Student>().Table("Student").Identity(x => x.StudentId);

        }
    }
}
