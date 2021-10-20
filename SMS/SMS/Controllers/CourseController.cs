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
    public class CourseController : Controller
    {
        ApiResponse apiResponse = new ApiResponse();
        CourseCore courseCore;
        public CourseController(IRepository<Course> iRepository)
        {
            courseCore = new CourseCore(iRepository);
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Create")]
        public ApiResponse Create(Course model)
        {
            apiResponse = courseCore.Create(model);
            return apiResponse;
        }
    }
}
