using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestServiceLab.Models
{
    public class Product
    {
        Dictionary<string, Double> products;

        public Product()
        {
            products = new Dictionary<string, double>
            {
                {"Apples", 3.99},
                {"Peaches", 4.05},
                {"Pumpkin", 13.99},
                {"Pie", 8.00}
            };
        }

        public Product(Dictionary<string, Double> products2)
        {
             products2 = new Dictionary<string, double>
            {
                {"Apples", 3.99},
                {"Peaches", 4.05},
                {"Pumpkin", 13.99},
                {"Pie", 8.00}
            };
        }


        public double GetPrice(String product)
        {
            try
            {
                return products[product];
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                return 0;
            }
        }

   
        public string[] GetProducts()
        {
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, Double> entry in products)
            {
                list.Add(entry.Key);
            }

            return list.ToArray();
        }

       
        public String GetCheapest()
        {
            string minKey = products.Keys.Min();
            return minKey;
        }

       
        public String GetCostliest()
        {
            string maxKey = products.Keys.Max();
            return maxKey;
        }

    
        public string[] GetMethods()
        {
            List<string> list = new List<string>();
            string[] methods = {
                "String GetCheapest()",
                "String GetCostliest()",
                "string[] GetMethods()",
                "double GetPrice(String product)",
                "string[] GetProducts()"
            };

            return methods;
        }
    }
}