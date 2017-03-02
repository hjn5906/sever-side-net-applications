using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestServiceLab.Models;

namespace RestServiceLab.Controllers
{
    public class ProductController : ApiController
    {

        Product products = new Product();
        
        //GET Services/Products
        //get all products 
        [Route("Services/Products")]
        public string[] getNames()
        {
            return products.GetProducts();
        }

        //GET Services/Products/Cheapest
        //get cheapest product
        [Route("Services/Products/Cheapest")]
        public String getCheapest()
        {
            return products.GetCheapest();
        }

        //GET Services/Products/Costliest
        //get costliest product
        [Route("Services/Products/Costliest")]
        public String getCostliest()
        {
            return products.GetCostliest();
        }

        //GET Services/Products/apple
        //get specific product
        [Route("Services/Products/{productName}", Name = "Product")]
        public double getPrice(String productName)
        {
            return products.GetPrice(productName);
        }

    }
}
