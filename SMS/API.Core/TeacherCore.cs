using Common;
using DataService.IRepo;
using SMS.Model;
using SMS.Model.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.Core
{
    public class TeacherCore
    {
        IRepository<Teacher> _iRepository;
        IRepository<Users> _iRepositoryUser;
        ApiResponse apiResponse = new ApiResponse();
        RandomPassword randomPassword = new RandomPassword();
        Users user = new Users();
        public  TeacherCore(IRepository<Teacher> iRepository, IRepository<Users> iRepositoryUser)
        {
            _iRepository = iRepository;
            _iRepositoryUser= iRepositoryUser;
        }
        public ApiResponse Create(Teacher model)
        {
            model.InsertedOn = DateTime.UtcNow.ToString();
            Users serachuser = _iRepositoryUser.Search<Users>(new { CNIC = model.CNIC }, Constant.SearchFromUser).FirstOrDefault();
            if(serachuser==null)
            {
                Teacher TeacherResponse = _iRepository.Create(model);
                user.EntityId = TeacherResponse.TeacherId;
                user.UserRoleId = (int)Enumerations.UserType.Teacher;
                user.Email = TeacherResponse.Email;
                user.Password = RandomPassword.CreatePassword(7);
                Users InsertedUser = _iRepositoryUser.Create(user);
            }
            else
            {
                apiResponse.Status = 1;
                apiResponse.Message = model.CNIC + "Sorry! Already Exsist";
            }
            return apiResponse;
        }
    }
}
