using Common;
using DataService.IRepo;
using POS.Model;
using POS.Model.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Core.Services
{
    public class CustomerCore
    {
        ApiResponse apiResponse = new ApiResponse();
        IRepository<Customer> iRepository;
        public CustomerCore(IRepository<Customer> _iRepository)
        {
            iRepository = _iRepository;
        }
        public ApiResponse Create(Customer model)
        {
            model.InsertedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = iRepository.Create(model);
            return apiResponse;
        }
        public ApiResponse Update(Customer model)
        {
            model.UpdatedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = iRepository.Update(model);
            return apiResponse;
        }
        public ApiResponse Search(Customer model)
        {
            object obj = new
            {
                CustomerId = model.CustomerId,
                CustomerName = model.CustomerName
            };
            List<Customer> customers = iRepository.Search<Customer>(obj, Constant.SpGetCustomer).ToList();
            apiResponse.Response = customers;
            return apiResponse;
        }
    }
}
