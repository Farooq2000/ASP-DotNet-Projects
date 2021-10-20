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
    public class StudentController : Controller
    {
        ApiResponse apiResponse = new ApiResponse();
        StudentCore studentCore;
        public StudentController(IRepository<Student> iRepository, IRepository<Users> iRepositoryUser)
        {
            studentCore = new StudentCore(iRepository,iRepositoryUser);
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Create")]
        public ApiResponse Create(Student model)
        {
            apiResponse = studentCore.Create(model);
           // apiResponse = studentCore.CreateAsync(model);
            return apiResponse;
        }
        [HttpPost]
        [Route("Update")]
        public ApiResponse Update(Student model)
        {
            apiResponse = studentCore.Update(model);
            return apiResponse;
        }

        [HttpPost]
        [Route("Search")]
        public ApiResponse Search(Student model)
        {
            apiResponse = studentCore.Update(model);
            return apiResponse;
        }
    }
}
