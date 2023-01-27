using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHomeTask
{
    public class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Product(int id, string productName, double productPrice)
        {
            this.ProductId = id;
            this.ProductName = productName;
            this.ProductPrice = productPrice;
        }
    }
}
