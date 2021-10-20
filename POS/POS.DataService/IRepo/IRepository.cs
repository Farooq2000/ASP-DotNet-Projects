using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.IRepo
{
    public interface IRepository<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> Search(object parameters, string query);
        IEnumerable<Model> Search<Model>(object parameters, string query);

        TEntity Create(TEntity model);
        TEntity Create<Model>(TEntity model);
        TEntity Update(TEntity model);
        TEntity Update<Model>(TEntity model);

    }
}
