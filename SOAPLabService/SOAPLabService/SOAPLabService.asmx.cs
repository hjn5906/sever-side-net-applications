using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAPLabService
{
    /// <summary>
    /// Summary description for SOAPLabService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SOAPLabService : System.Web.Services.WebService
    {
        Dictionary<string, Double> products;

        public SOAPLabService(){
            products = new Dictionary<string, double>
            {
                {"Apples", 3.99},
                {"Peaches", 4.05},
                {"Pumpkin", 13.99},
                {"Pie", 8.00}
            };
        }

        [WebMethod]
        public double GetPrice(String product)
        {
            return products[product];
        }

        [WebMethod]
        public string[] GetProducts()
        {
            List<string> list = new List<string>();
            foreach(KeyValuePair<string, Double> entry in products)
            {
                list.Add(entry.Key);
            }

            return list.ToArray();
        }

        [WebMethod]
        public String GetCheapest()
        {
            string minKey = products.Keys.Min();
            return minKey;
        }

        [WebMethod]
        public String GetCostliest()
        {
            string maxKey = products.Keys.Max();
            return maxKey;
        }

        [WebMethod]
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
