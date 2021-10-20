using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Constant
    {
        #region StoreProcedure
        public const string SpCreateProduct = "sp_CreateProduct";

        public const string SpUpdateProduct = "sp_UpdateProduct";

        public const string SpGetProduct = "usp_GetProduct";

        public const string SpCreateOrders = "usp_InsertOrder";

        public const string SpUpdateOrders = "usp_UpdateOrder";

        public const string SpSearchOrders = "usp_SearchOrders";

        public const string SpGetCustomer = "usp_GetCustomer";

        public const string GetOrderById = "usp_GetOrderId";//usp_GetOrderFromId

        public const string GetOrderFromId = "usp_GetOrderFromId";//

        public const string GetOrderByDateAndId = "usp_GetOrderByDateAndId";
        #endregion

        public enum Type
        {
            DairyProduct = 1 ,
            Chocolates,
            Juice,
            BakingProduct


        }
    }
}
