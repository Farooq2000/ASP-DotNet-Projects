using API.Core.Services;
using DataService.IRepo;
using Microsoft.AspNetCore.Mvc;
using ProductOFSystem.Model.Model.Data;
using ProductOFSystem.Model.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOFSystem.Controllers
{
    public class OrdersController : Controller
    {
        IRepository<Orders> iRepository;
        ApiResponse apiResponse = new ApiResponse();
        OrdersCore ordersCore;
      
        public OrdersController(IRepository<Orders> iRepository)
        {
            ordersCore = new OrdersCore(iRepository);
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Create")]
        public ApiResponse Create(Orders model)
        {
            apiResponse = ordersCore.Create(model);
            return apiResponse;
        }
        [HttpPost]
        [Route("Update")]
        public ApiResponse Update(Orders model)
        {
            apiResponse = ordersCore.Update(model);
            return apiResponse;
        }
        [HttpPost]
        [Route("Search")]
        public ApiResponse Search(Orders model)
        {
            apiResponse.Response = ordersCore.Search(model);
            return apiResponse;
        }
    }
}
