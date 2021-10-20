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
    public class FatherController : Controller
    {
        FatherCore fatherCore;
        ApiResponse apiResponse = new ApiResponse();
        public FatherController(IRepository<Father> iRepository)
        {
            fatherCore = new FatherCore(iRepository);
        }
        public IActionResult Index()
        {
            return View();
        }
       [HttpPost]
       [Route("Create")]
       public ApiResponse Create(Father model)
        {
            apiResponse = fatherCore.Create(model);
            return apiResponse;
        }
    }
}
