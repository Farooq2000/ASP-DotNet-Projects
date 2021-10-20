using DataService.IRepo;
using SMS.Model;
using SMS.Model.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Core
{
    public class CourseCore
    {
        IRepository<Course> _iRepository;
        ApiResponse apiResponse = new ApiResponse();
        public CourseCore(IRepository<Course> iRepository)
        {
            _iRepository = iRepository;
        }
        public ApiResponse Create(Course model)
        {
            model.InsertedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = _iRepository.Create(model);
            return apiResponse;
        }
    }
}
