using Model;
using Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataServices.IRepository
{
    public interface ITeacherRepo
    {
        public ApiResponse Create(Teacher model);
        public ApiResponse Update(Teacher model);
        public ApiResponse Search(int ID);

    }
}
