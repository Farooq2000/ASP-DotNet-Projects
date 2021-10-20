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
   public class OrdersCore
    {
        ApiResponse apiResponse = new ApiResponse();
       IRepository<Orders> iRepository;
        public OrdersCore(IRepository<Orders> _iRepository)
        {
            iRepository = _iRepository;


        }
        public ApiResponse Create(Orders model)
        {
            model.InsertedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = iRepository.Create(model);
            return apiResponse;
        }
        public ApiResponse Update(Orders model)
        {
            model.UpdatedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = iRepository.Update(model);
            return apiResponse;
        }
        public ApiResponse Search(Orders model)
        {
            Object searchModel = new
            {
                OrderId = model.OrderId,
                Customer_ID = model.CustomerId,
                Amount = model.Amount,
                Discount = model.Discount,
                InsertedOn = model.InsertedOn,
                Rider_ID = model.RiderId

            };
            List<Orders> ordersModel = iRepository.Search<Orders>(searchModel, Constant.SpSearchOrders).ToList();
            apiResponse.Response = ordersModel;
            return apiResponse;
        }
    }
}
