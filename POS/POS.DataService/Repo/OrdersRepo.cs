using Common;
using Dapper;
using DataService.IRepo;
using POS.DataService.IRepo;
using POS.Model;
using POS.Model.Data;
using POS.Model.Model.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataService.Repo
{
    public class OrdersRepo : IOrdersRepo
    {
        IConnectionRepo _connection;
        ApiResponse apiResponse = new ApiResponse();
        public OrdersRepo(IConnectionRepo iConnectionRepo/*is mai jo ae ga woh startup sai ae ga*/)
        {
            _connection = iConnectionRepo;
        }
        public ApiResponse Create(Orders model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
                {
                    conn.Open();
                    return conn.Query<ApiResponse>(Constant.SpCreateOrders, param: model, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
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

        public List<Orders> Search(Object model)
        {
           
                using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
                {
                    conn.Open();
                    return conn.Query<Orders>(Constant.SpSearchOrders, param: model, commandType: System.Data.CommandType.StoredProcedure).ToList();
                }
        }

        public ApiResponse Update(Orders model)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
                    {
                        conn.Open();
                        Object a = conn.Query<Object>(Constant.SpUpdateOrders, param: model, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
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
        }
    }

