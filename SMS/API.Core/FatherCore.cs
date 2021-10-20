using DataService.IRepo;
using SMS.Model;
using SMS.Model.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Core
{
    public class FatherCore
    {
        ApiResponse apiResponse = new ApiResponse();
        IRepository<Father> _iRepository;
        public FatherCore(IRepository<Father> iRepository)
        {
            _iRepository = iRepository;
        }
        public ApiResponse Create(Father model)
        {
            model.InsertedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = _iRepository.Create(model);
            return apiResponse;
        }
    }
}
