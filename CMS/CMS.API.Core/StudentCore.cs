using DataServices.IRepository;
using Model;
using Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.API.Core
{//repostry is lie create kiaa hai k is k trow database mai data insert update or delete hoga
    public class StudentCore
    {
        IStudentRepo iStudentRepo;
        public StudentCore(IStudentRepo _iStudentRepo)
        {
            iStudentRepo = _iStudentRepo;
        }
        ApiResponse apiResponse = new ApiResponse();
        public ApiResponse Create(Student model)
        { 
            apiResponse = iStudentRepo.Create(model);
            return apiResponse;
        }
        public ApiResponse Update(Student model)
        {
            apiResponse = iStudentRepo.Update(model);
            return apiResponse;
        }

        public ApiResponse Search(int ID)
        {
            
            return apiResponse;
        }
    }
}

