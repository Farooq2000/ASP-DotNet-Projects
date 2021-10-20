using Dapper;
using DataService.IRepo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Z.Dapper.Plus;
namespace DataService.Repo
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        IConnectionRepo _connection;
        public GenericRepository(IConnectionRepo iConnectionRepo)
        {
            _connection = iConnectionRepo;
        }
        public TEntity Create(TEntity model)
        {
            using (SqlConnection conn =new SqlConnection(_connection.ConnectionString) )
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

        public IEnumerable<TEntity> Search(object parameters, string query)
        {
            using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
            {
                conn.Open();
                return conn.Query<TEntity>(query, param: parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }

        public IEnumerable<Model> Search<Model>(object parameters, string query)
        {
            using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
            {
                conn.Open();
                return conn.Query<Model>(query, param: parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }

        public TEntity Update(TEntity model)
        {
            using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
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
