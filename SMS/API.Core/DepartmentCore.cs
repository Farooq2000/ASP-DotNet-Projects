using DataService.IRepo;
using SMS.Model;
using SMS.Model.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Core
{
    public class DepartmentCore
    {
        ApiResponse apiResponse = new ApiResponse();
        IRepository<Department> _iRepository;
        public DepartmentCore(IRepository<Department> iRepository)
        {
            _iRepository = iRepository;
        }
        public ApiResponse Create(Department model)
        {
            model.InsertedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = _iRepository.Create(model);
            return apiResponse;
        }
    }
}
