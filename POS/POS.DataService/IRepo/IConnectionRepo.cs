using System;
using System.Collections.Generic;
using System.Text;

namespace POS.DataService.IRepo
{
    public interface IConnectionRepo
    {
        string ConnectionString { get; }
    }
}
