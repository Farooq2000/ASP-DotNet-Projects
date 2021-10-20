
using API.Core.Services;
using DataService.IRepo;
using Microsoft.AspNetCore.Mvc;
using POS.Model;
using POS.Model.Model.Data;

namespace POS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        ApiResponse apiResponse = new ApiResponse();
        CustomerCore customerCore;
        public CustomerController(IRepository<Customer> iRepository)
        {
            customerCore = new CustomerCore(iRepository);
        }
        [Route("Create")]
        [HttpPost]
        public ApiResponse Create(Customer model)
        {
            apiResponse = customerCore.Create(model);
            return apiResponse;
        }
        [HttpPost]
        [Route("Update")]
        public ApiResponse Update(Customer model)
        {
            apiResponse = customerCore.Update(model);
            return apiResponse;
        }
        [HttpPost]
        [Route("Search")]
        public ApiResponse Search(Customer model)
        {
            apiResponse = customerCore.Search(model);
            return apiResponse;
        }
    }
}
