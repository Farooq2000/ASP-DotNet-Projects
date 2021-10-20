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
//studentmodel mai ja k dob k datatype ko string krni hai
namespace DataServices.Repository
{
    public class StudentRepo : IStudentRepo
    {
        ApiResponse apiResponse = new ApiResponse();

        IConnectionRepo _connection;
        public StudentRepo(IConnectionRepo iConnectionRepo/*is mai jo ae ga woh startup sai ae ga*/)
        {
            _connection = iConnectionRepo;
        }
        public ApiResponse Create(Student model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
                {
                    conn.Open();
                    return conn.Query<ApiResponse>(Constant.SpCreateStudent, param: model, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                   
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

        public ApiResponse Update(Student model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connection.ConnectionString))
                {
                    conn.Open();
                    return conn.Query<ApiResponse>(Constant.SpUpdateStudent, param: model, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return apiResponse = new ApiResponse
                {
                    StatusCode = 1,
                    Response = ex.Message
                };
            }
        }
    }
}
