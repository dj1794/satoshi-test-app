using Microsoft.AspNetCore.Mvc;
using Satoshi.Domain.Sales;
using SatoshiTestApi.Models;
using SatoshiTestApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SathoshiTestApi.Controllers
{
    [ApiController]
    [Route("api/Sales")]
    public class SalesOderController : Controller
    {  
        private readonly IDataService dataService;
        public SalesOderController(IDataService _dataService)
        {
            dataService = _dataService;
        }
        [HttpGet]
        [Route("GetOrders")]
        public async Task<IActionResult> GetOrders()
        {
           return Ok(await  dataService.GetOrders());
        }
        [HttpGet]
        [Route("GetProducts")]
        public async Task<IActionResult> GetProducts()
        {
            var data = await dataService.GetProducts();
            return Ok(data);
        }
        [HttpPost]
        [Route("SaveOrders")]
        public async Task<IActionResult> SaveOrders([FromBodyAttribute] SalesOrderModel salesOrder)
        {
            var status = await dataService.SaveOrder(salesOrder);
            return Ok(status);
        }
    }
}
