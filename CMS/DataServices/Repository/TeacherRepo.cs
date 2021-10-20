using Common;
using Dapper;
using DataServices.IRepository;
using Model;
using Model.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataServices.Repository
{
    public class TeacherRepo : ITeacherRepo
    {
        IConnectionRepo _connection;
        ApiResponse apiResponse = new ApiResponse();
        public TeacherRepo(IConnectionRepo iConnectionRepo)
        {
            _connection = iConnectionRepo;
        }
        public ApiResponse Create(Teacher model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
                {
                    conn.Open();
                    return conn.Query<ApiResponse>(Constant.SpCreateTeacher, param: model, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                    
                }
            }
            catch (Exception ex)
            {
                return apiResponse = new ApiResponse
                {
                    StatusCode = 1,
                    Response = ex.Message
                };
            }//is body k throw data insert krwaen gai
        }
        public ApiResponse Update(Teacher model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
                {
                    conn.Open();
                    return conn.Query<ApiResponse>(Constant.SpCreateTeacher, param: model, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                return apiResponse = new ApiResponse
                {
                    StatusCode = 1,
                    Response = ex.Message
                };
            }//is body k throw data insert krwaen gai
        }
        public ApiResponse Search(int ID)
        {
            throw new NotImplementedException();
        }

    }
}
