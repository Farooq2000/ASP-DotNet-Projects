using POS.Model;
using POS.Model.Data;
using System.Collections.Generic;

namespace POS.DataService.IRepo
{
    public interface IProductRepo
    {
        public ApiResponse Create(Product model);
        public ApiResponse Update(Product model);
        public List<Product> search(int id);
    }
}
