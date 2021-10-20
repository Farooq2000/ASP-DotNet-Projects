using API.Core;
using DataService.IRepo;
using Microsoft.AspNetCore.Mvc;
using SMS.Model;
using SMS.Model.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TeacherController : Controller
    {
        TeacherCore teacherCore;
        ApiResponse apiResponse = new ApiResponse();
        public TeacherController(IRepository<Teacher> iRepository, IRepository<Users> iRepositoryUser)
        {
            teacherCore = new TeacherCore(iRepository,iRepositoryUser);
            
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Create")]
        public ApiResponse Create(Teacher model)
        {
            apiResponse = teacherCore.Create(model);
            return apiResponse;
        }
    }
}
