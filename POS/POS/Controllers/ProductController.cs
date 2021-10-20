using API.Core.Services;
using DataService.IRepo;
using Microsoft.AspNetCore.Mvc;
using POS.DataService.IRepo;
using POS.Model;
using POS.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        ApiResponse apiResponse = new ApiResponse();
        ProductCore productCore;
        public ProductController(IProductRepo iProduct, IRepository<Product> iRepository)
        {
            productCore = new ProductCore(iProduct, iRepository);
        }

        [HttpPost]
        [Route("Create")]
        public ApiResponse Create(Product model)
        {
            apiResponse = productCore.Create(model);
            return apiResponse;
        }
        [HttpPost]
        [Route("Update")]
        public ApiResponse Update(Product model)
        {
            apiResponse = productCore.Update(model);
            return apiResponse;
        }

        [HttpPost]
        [Route("Search")]
        public ApiResponse Search(Product model)
        {
            apiResponse = productCore.Search(model);
            return apiResponse;
        }

        [HttpPost]
        [Route("TotalStock")]
        public ApiResponse TotalStock(Product model)
        {
            apiResponse = productCore.TotalStock(model);
            return apiResponse;
        }
    }
}
