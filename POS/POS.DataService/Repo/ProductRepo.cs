using Common;
using Dapper;
using POS.Common;
using POS.DataService.IRepo;
using POS.Model;
using POS.Model.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DataService.Repo
{
    public class ProductRepo : IProductRepo
    {
        IConnectionRepo _connection;
        ApiResponse apiResponse;
        public ProductRepo(IConnectionRepo Connection)
        {
            _connection = Connection;
            apiResponse = new ApiResponse();
        }

        public ApiResponse Create(Product model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
                {
                    conn.Open();
                    Object a  =  conn.Query<Object>(Constant.SpCreateProduct, param: model, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                    return apiResponse;
                }
            }
            catch (Exception ex)
            {
                return apiResponse = new ApiResponse
                {
                    status = 1,
                    Response = ex.Message
                };
            }
            
        }



        public ApiResponse Update(Product model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
                {
                    conn.Open();
                    return conn.Query<ApiResponse>(Constant.SpUpdateProduct, param: model, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return apiResponse = new ApiResponse
                {
                    status = 1,
                    Response = ex.Message
                };
            }

        }


        public List<Product> search(int id)
        {
            //try
            //{
                using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
                {
                    conn.Open();
                    return conn.Query<Product>(Constant.SpGetProduct, param: new { ProductId  = id}, commandType: System.Data.CommandType.StoredProcedure).ToList();
                }
            //}
            //catch (Exception ex)
            //{
            //    return apiResponse = new ApiResponse
            //    {
            //        status = 1,
            //        Response = ex.Message
            //    };
            //}

        }
    }

}
