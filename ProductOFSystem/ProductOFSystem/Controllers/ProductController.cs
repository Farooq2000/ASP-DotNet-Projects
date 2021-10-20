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
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductController : Controller
    {
        IRepository<Product> iRepository;
        ApiResponse apiResponse = new ApiResponse();
        ProductCore productCore;
        public ProductController(IRepository<Product> iRepository)
        {
            productCore = new ProductCore(iRepository);
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Create")]
        public ApiResponse Create(Product model)
        {
            model.InsertedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = productCore.Create(model);//apiResponse = productCore.Create(model);
            return apiResponse;
        }
        [HttpPost]
        [Route("Update")]
        public ApiResponse Update(Product model)
        {
            model.UpdatedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = productCore.Update(model);
            return apiResponse;
        }
        [HttpPost]
        [Route("Search")]
        public ApiResponse Search(Product model)
        {
            apiResponse = productCore.Search(model);
            return apiResponse;
        }
    }
}
