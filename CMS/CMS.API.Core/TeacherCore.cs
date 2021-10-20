using DataServices.IRepository;
using Model;
using Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.API.Core
{
    public class TeacherCore
    {
        ITeacherRepo iTeacherRepo;
        ApiResponse apiResponse = new ApiResponse();
        public TeacherCore(ITeacherRepo _iTeacherRepo)
        {
            iTeacherRepo = _iTeacherRepo;
        }
        public ApiResponse Create(Teacher model)
        {
            apiResponse = iTeacherRepo.Create(model);
            return apiResponse;
        }
        public ApiResponse Update(Teacher model)
        {
            apiResponse = iTeacherRepo.Update(model);
            return apiResponse;
        }

    }
}
