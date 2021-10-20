using Common;
using DataService.IRepo;
using ProductOFSystem.Model.Model.Data;
using ProductOFSystem.Model.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.Core.Services
{
    public class ProductCore
    {
        ApiResponse apiResponse = new ApiResponse();
        IRepository<Product> iRepository;
        public ProductCore(IRepository<Product> _iRepository)
        {
            iRepository = _iRepository;
        }
        public ApiResponse Create(Product model)
        {
            model.InsertedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = iRepository.Create(model);
            return apiResponse;
        }
        public ApiResponse Update(Product model)
        {
            model.UpdatedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = iRepository.Update(model);
            return apiResponse;
        }
        public ApiResponse Search(Product model)
        {
            Object searchModel = new
            {
                ProductId = model.ProductId,
                Name = model.Name,
                NetPrice = model.NetPrice,
                RetailPrice = model.RetailPrice,
                ManufactedBy = model.ManufactedBy,
                Category = model.Category
            };
            List<Product> productList = iRepository.Search<Product>(searchModel, Constant.SpGetProduct).ToList();
            apiResponse.Response = productList;
            return apiResponse;
        }
    }
}
