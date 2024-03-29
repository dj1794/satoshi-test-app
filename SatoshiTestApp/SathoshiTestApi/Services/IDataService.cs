﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Satoshi.Domain.Sales;
using SatoshiTestApi.Models; 
namespace SatoshiTestApi.Services
{
    public interface IDataService
    {
        public Task<bool> SaveOrder(SalesOrderModel salesOrder);
        public Task<List<SalesOrderModel>> GetOrders();
        public Task<List<ProductsModel>> GetProducts();
    }
}
