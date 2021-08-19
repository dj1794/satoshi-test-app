using SatoshiTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatoshiTestApp.Services
{
    public class AdoDataService : IDataService
    {
        public List<SalesOrderModel> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductsModel>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public bool SaveOrder(SalesOrderModel salesOrder)
        {
            throw new NotImplementedException();
        }

        Task<List<SalesOrderModel>> IDataService.GetOrders()
        {
            throw new NotImplementedException();
        }

        Task<bool> IDataService.SaveOrder(SalesOrderModel salesOrder)
        {
            throw new NotImplementedException();
        }
    }
}
