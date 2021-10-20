using Common;
using DataService.IRepo;
using POS.DataService.IRepo;
using POS.Model;
using POS.Model.Data;
using POS.Model.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.Core.Services
{
    public class ProductCore
    {
        ApiResponse apiResponse = new ApiResponse();
        IProductRepo iProductRepo;
        IRepository<Product> iRepository;
        public ProductCore(IProductRepo _iProductRepo,IRepository<Product> _iRepository)
        {
            iProductRepo = _iProductRepo;
            iRepository = _iRepository;
        }
        

        public ApiResponse Create(Product model)
        {
            model.InsertedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = iRepository.Create(model);
            return apiResponse;
        }

        //update product
        public ApiResponse Update(Product model)
        {
            model.UpdatedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = iRepository.Update(model);
            return apiResponse;
        }


        //get product
        //update product
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
            List<Product> productList = iRepository.Search<Product>(searchModel,Constant.SpGetProduct).ToList();
            apiResponse.Response = productList;
            return apiResponse;
        }


        public ApiResponse TotalStock(Product model)
        {
            StockViewModel stockViewModel = new StockViewModel();
            Object searchModel = new
            {
                ProductId = model.ProductId,
                Name = model.Name,
                NetPrice = model.NetPrice,
                RetailPrice = model.RetailPrice,
                ManufactedBy = model.ManufactedBy,
                Category = model.Category

            };
            stockViewModel.productList = iRepository.Search<Product>(searchModel, Constant.SpGetProduct).ToList();
            try
            {
                foreach (var items in stockViewModel.productList)
                {
                    stockViewModel.TotalStockNetPrice = stockViewModel.TotalStockNetPrice + ((decimal)items.NetPrice * (decimal)items.Stock);
                    stockViewModel.TotalStockRetailPrice = stockViewModel.TotalStockRetailPrice + ((decimal)items.RetailPrice * (decimal)items.Stock);
                }
            }
            catch {  }
            
            apiResponse.Response = stockViewModel;
            return apiResponse;
        }


    }

}
