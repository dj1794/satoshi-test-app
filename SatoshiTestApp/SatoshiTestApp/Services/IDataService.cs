using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SatoshiTestApp.Models; 
namespace SatoshiTestApp.Services
{
    public interface IDataService
    {
        public Task<bool> SaveOrder(SalesOrderModel salesOrder);
        public Task<List<SalesOrderModel>> GetOrders();
        public Task<List<ProductsModel>> GetProducts();
    }
}
