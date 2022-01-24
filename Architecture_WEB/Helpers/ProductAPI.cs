using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Architecture_WEB.Helpers
{
    public class ProductAPI
    {
        public HttpClient Initial() 
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:54290/");
            return client;
        }
    }
}
