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
    public class DepartmentController : Controller
    {
        DepartmentCore departmentCore;
        ApiResponse apiResponse = new ApiResponse();
        public DepartmentController(IRepository<Department> iRepository)
        {
            departmentCore = new DepartmentCore(iRepository);
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Create")]
        public ApiResponse Create(Department model)
        {
            apiResponse = departmentCore.Create(model);
            return apiResponse;
        }

    }
}
