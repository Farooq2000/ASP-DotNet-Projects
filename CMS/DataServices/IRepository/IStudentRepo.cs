using Model;
using Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataServices.IRepository
{
    public interface IStudentRepo
    {
        public ApiResponse Create(Student model);
        public ApiResponse Update(Student model);
        public ApiResponse Search(int ID);
        
        
    }
}
