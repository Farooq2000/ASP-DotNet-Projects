using API.Core.Services;   
using DataService.IRepo;
using Microsoft.AspNetCore.Mvc;
using POS.Model;
using POS.Model.Data;
using POS.Model.Model.Data;
using POS.Model.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        ApiResponse apiResponse = new ApiResponse();
        OrdersCore ordersCore;
       
        public OrdersController(IRepository<OrderItem> iRepositoryOrdersItem,IRepository<Orders> iRepository, IRepository<Product> iRepositoryProduct)
        {
            ordersCore = new OrdersCore(iRepositoryOrdersItem,iRepository, iRepositoryProduct);
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
        [HttpPost]
        [Route("GetOrderApi")]
        public ApiResponse GetOrderApi(BaseFilter model)
        {
            apiResponse = ordersCore.GetOrderApi(model);
            return apiResponse;
        }
        [HttpPost]
        [Route("TotalExpenseAndProfit")]
        public ApiResponse TotalExpenseAndProfit(   BaseFilter baseFilter)
        {
            apiResponse = ordersCore.TotalExpenseAndProfit(baseFilter);
            return apiResponse;
        }
    }
}
