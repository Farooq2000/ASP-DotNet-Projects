using CMS.API.Core;
using DataServices.IRepository;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    [ApiController]//yai btadia k api k controller hai
    [Route("api/[controller]")]
    public class TeacherController : Controller
    {
        ApiResponse apiResponse = new ApiResponse();
        TeacherCore teacherCore;

        public TeacherController(ITeacherRepo iTeacherRepo)
        {
            teacherCore = new TeacherCore(iTeacherRepo);
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(Teacher model)
        {
            apiResponse = teacherCore.Create(model);
            return Ok(apiResponse);
        }
        [HttpPost]
        [Route("Update")]
        public IActionResult Update(Teacher model)
        {
            apiResponse = teacherCore.Update(model);
            return Ok(apiResponse);
        }


        [HttpGet]
        [Route("Search")]
        public IActionResult Search()
        {
            return View();
        }
    }
}
