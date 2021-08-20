using Microsoft.EntityFrameworkCore;
using SatoshiTestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatoshiTestApi.Services
{
    public class EntityDataService : IDataService
    {
        private readonly SatoshiTestDbContext context;
        public EntityDataService(SatoshiTestDbContext _context)
        {
            context = _context;
        }
        public async Task<List<SalesOrderModel>> GetOrders()
        {
            var data =await context.SalesOrders.ToListAsync();
            return data;
        }

        public async Task<List<ProductsModel>> GetProducts()
        {
            var data = await  context.Products.ToListAsync();
            return data;
        }

        public async Task<bool> SaveOrder(SalesOrderModel salesOrder)
        {
            try
            {

                context.SalesOrders.Add(salesOrder);
                var status = await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
