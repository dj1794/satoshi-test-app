using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Satoshi.Domain.Sales
{
    public class SalesOrderModel
    {
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string customerName { get; set; }
        [Required]
        public decimal price { get; set; }
        public int productID { get; set; }
    }

    public class ProductsModel
    { 
        public int id { get; set; }
        public string productName { get; set; }
    }

}
