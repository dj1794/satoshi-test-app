using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SatoshiTestApp.Models
{
    public class SalesOrderModel
    {
        public int id { get; set; }
        public string customerName { get; set; }
        public decimal price { get; set; }
        public int productID { get; set; }
        public virtual List<ProductsModel> products{get;set;}
    }

    public class ProductsModel
    { 
        public int id { get; set; }
        public string productName { get; set; }
    }

}
