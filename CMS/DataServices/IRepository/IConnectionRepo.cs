using System;
using System.Collections.Generic;
using System.Text;

namespace DataServices.IRepository
{
    public interface IConnectionRepo
    {
        string ConnectionString { get; }
        
    }
}
