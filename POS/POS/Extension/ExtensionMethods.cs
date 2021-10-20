using DataService.IRepo;
using DataService.Repo;
using Microsoft.Extensions.DependencyInjection;
using POS.Controllers;
using POS.DataService.IRepo;
using POS.DataService.Repo;
using POS.Model;
using POS.Model.Data;
using POS.Model.Model.Data;

namespace POS.Extension
{
    public static class ExtensionMethods
    {

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddSingleton<IConnectionRepo, ConnectionFactory>();
            services.AddSingleton<IProductRepo, ProductRepo>();
            services.AddSingleton<IOrdersRepo,  OrdersRepo>();
            services.AddSingleton<IRepository<Orders>, GenericRepository<Orders>>();
            services.AddSingleton<IRepository<Product>, GenericRepository<Product>>();
            services.AddSingleton<IRepository<Customer>, GenericRepository<Customer>>(); 
            services.AddSingleton<IRepository<OrderItem>, GenericRepository<OrderItem>>();


            return services;
        }
    }
}
