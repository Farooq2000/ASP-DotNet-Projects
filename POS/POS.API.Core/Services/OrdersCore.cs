using Common;
using DataService.IRepo;
using Newtonsoft.Json;
using POS.DataService.Repo;
using POS.Model;
using POS.Model.Data;
using POS.Model.Model.Data;
using POS.Model.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Dapper.SqlMapper;

namespace API.Core.Services
{
    public class OrdersCore :ConnectionFactory
    {
        IOrdersRepo iOrdersRepo;
        ApiResponse apiResponse = new ApiResponse();
        private IRepository<OrderItem> iRepositoryOrdersItem;
        private IRepository<Orders> iRepository;
      //  private IRepository<OrderItem> iRepositoryOrderItem;
        private IRepository<Product> iRepositoryProduct;
        public OrdersCore(IRepository<OrderItem> _iRepositoryOrdersItem, IRepository<Orders> _iRepository, IRepository<Product> _iRepositoryProduct)
        {
            iRepositoryOrdersItem = _iRepositoryOrdersItem;
            iRepository = _iRepository;
            iRepositoryProduct = _iRepositoryProduct;
        }
        public ApiResponse Create(Orders model)
        {
            List<Product> productList = new List<Product>();
            Customer customer = iRepository.Search<Customer>(new { CustomerId = model.CustomerId }, Constant.SpGetCustomer).FirstOrDefault();
            List<OrderItem> items = JsonConvert.DeserializeObject<List<OrderItem>>(model.Items);
           foreach (var item in items)
            {
                Product productdetail = iRepository.Search<Product>(new { ProductId = item.ProductId }, Constant.SpGetProduct).FirstOrDefault();
                //if (productdetail.Stock > item.ProductQuantity)
                //{
                if (customer.CustomerType == (int)Enumerations.CustomerType.Individual)
                {
                    //model.Amount += (decimal)(productdetail.RetailPrice * item.ProductQuantity);
                    model.TotalAmount += item.TotalAmount;
                    model.Profit += (decimal)((productdetail.RetailPrice - productdetail.NetPrice) * item.ProductQuantity);
                }
                if (customer.CustomerType == (int)Enumerations.CustomerType.ShopKeeper)
                {
                    model.TotalAmount += item.TotalAmount;
                    model.Profit += (decimal)((productdetail.WholeSellerPrice - productdetail.NetPrice) * item.ProductQuantity);
                }
                productdetail.Stock = productdetail.Stock - item.ProductQuantity;//Upate Stock
                productList.Add(productdetail);
                // OrderItem orderItem = iRepository.Create(productdetail);
                //orderItem.Add();
                model.TotalAmount += item.TotalAmount;
                //}
                //else
                //{
                //    apiResponse.status = 1;
                //    apiResponse.Message = productdetail.Name +"Sorry! Out of Stock";
                //    return apiResponse;
                //}
            }
            model.TotalAmount = (decimal)model.Amount - (decimal)model.Discount;
            model.InsertedOn = DateTime.UtcNow.ToString();
            Orders orders = iRepository.Create(model);
            foreach (var item in items)
            {
                item.OrderId = orders.OrderId;
                item.CustomerId = customer.CustomerId;
                apiResponse.Response = iRepositoryOrdersItem.Create(item);
            }
            foreach (Product product in productList){
                product.UpdatedOn = DateTime.UtcNow.ToString();
                iRepositoryProduct.Update(product);
            }
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
        public ApiResponse GetOrderApi(BaseFilter model)
        {
            OrdersView orderView = new OrdersView();
            object SearchOrder = new
            {
                OrderId = model.OrderId,
                CustomerName = model.CustomerName,
                CustomerId = model.CustomerId,
                Address = model.Address,
                ShopName = model.ShopName,
                DeliveryTime = model.DeliveryTime
            };
            apiResponse.Response = iRepository.Search<OrdersView>(SearchOrder, Constant.GetOrderFromId).ToList();
            return apiResponse;
        }
        public decimal tAmount;
        public ApiResponse TotalExpenseAndProfit( BaseFilter baseFilter)
        {        
        Object searchModel = new
            {
                OrderId = baseFilter.OrderId,
                FromDate=baseFilter.FromDate.ToString("MM/dd/yyyy 00:00:00"),
                ToDate=baseFilter.ToDate.ToString("MM/dd/yyyy 23:59:59"),
        };
            List<Orders> List = iRepository.Search<Orders>(searchModel, Constant.GetOrderByDateAndId).ToList();
           
            
            
            TotalOrderExpenseAndProfitModel totalOrderExpenseAndProfitModel=new TotalOrderExpenseAndProfitModel();
           totalOrderExpenseAndProfitModel.OrderList= iRepository.Search<Orders>(searchModel, Constant.SpSearchOrders).ToList();
           foreach(var item in totalOrderExpenseAndProfitModel.OrderList)
            {
                totalOrderExpenseAndProfitModel.TotalProfit += item.Profit;
                totalOrderExpenseAndProfitModel.TotalAmount += item.TotalAmount;
            }
            totalOrderExpenseAndProfitModel.TotalCostPrice = totalOrderExpenseAndProfitModel.TotalAmount - totalOrderExpenseAndProfitModel.TotalProfit;
            return apiResponse; 
        }

    }
}
