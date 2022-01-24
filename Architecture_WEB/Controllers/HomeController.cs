using Architecture_WEB.Helpers;
using Architecture_WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Architecture_WEB.Controllers
{
    public class HomeController : Controller
    {
        ProductAPI _apiHelper = new ProductAPI();
        public async Task<IActionResult> Index()
        {
            List<ProductModel> product = new List<ProductModel>();
            HttpClient client = _apiHelper.Initial();
            HttpResponseMessage res = await client.GetAsync("Product/GetAllProduct");

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                product = JsonConvert.DeserializeObject<List<ProductModel>>(result);
            }
            return View(product);
        }




        public async Task<IActionResult> Details(ProductModel productModel)
        {
            var ProductModel = new ProductModel();
            HttpClient client = _apiHelper.Initial();
            HttpResponseMessage res = await client.GetAsync($"Product/GetProductr?id={productModel.ProductID}");

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                ProductModel = JsonConvert.DeserializeObject<ProductModel>(result);
            }

            return View(ProductModel);
        }



        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(ProductModel ProductModel)
        {
            HttpClient client = _apiHelper.Initial();
            var post = client.PostAsJsonAsync<ProductModel>("Product/InsertProduct", ProductModel);
            post.Wait();
            var result = post.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        

        public async Task<IActionResult> Delete(int ID)
        {
            var person = new ProductModel();
            HttpClient client = _apiHelper.Initial();
            HttpResponseMessage res = await client.GetAsync($"Product/DeleteProduct?id=2");
            return RedirectToAction("Index");
        }
    }
}
