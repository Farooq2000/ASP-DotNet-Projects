using DataService.IRepo;
using ProductOFSystem.Model.Model.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Z.Dapper.Plus;

namespace DataService.Repo
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        IConnectionRepo _connection;
        ApiResponse apiResponse = new ApiResponse();
        public GenericRepository(IConnectionRepo iConnectionRepo)
        {
             _connection= iConnectionRepo;
        }
        public TEntity Create(TEntity model)
        {
            using (SqlConnection conn=new SqlConnection(_connection.ConnectionString))
            {
                conn.Open();
                return conn.BulkInsert<TEntity>(model).CurrentItem;
            }
        }

        public TEntity Create<Model>(TEntity model)
        {
            using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
            {
                conn.Open();
                return conn.BulkInsert<TEntity>(model).CurrentItem;
            }
        }

        public IEnumerable<TEntity> Search(object parameter, string query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model> Serach<Model>(object parameter, string query)
        {
            throw new NotImplementedException();
        }
        
        public TEntity Update(TEntity model)
        {
            using (SqlConnection conn=new SqlConnection(_connection.ConnectionString))
            {
                conn.Open();
                return conn.BulkUpdate<TEntity>(model).CurrentItem;
            }
        }

        public TEntity Update<Model>(TEntity model)
        {
            using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
            {
                conn.Open();
                return conn.BulkUpdate<TEntity>(model).CurrentItem;
            }
        }
    }
}
