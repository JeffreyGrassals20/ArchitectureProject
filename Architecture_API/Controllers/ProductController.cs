using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service;
using Domain;

namespace Architecture_API
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IProductDetailsService productDetailsService;

        public ProductController(IProductService productService, IProductDetailsService productDetailsService)
        {
            this.productService = productService;
            this.productDetailsService = productDetailsService;
        }

        [HttpGet (nameof(GetAllProduct))]
        public IActionResult GetAllProduct()
        {
            var result = productService.GetAllProduct();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }



        [HttpGet(nameof(GetProductr))]
        public IActionResult GetProductr(int id)
        {
            var result = productService.GetProduct(id);
            if (result != null)
                return Ok(result);

            return BadRequest("No Records Found");
        }

        [HttpPost(nameof(InsertProduct))]
        public IActionResult InsertProduct(Product product)
        {
            productService.InsertProduct(product);
            return Ok("Data Inserted");
        }

        [HttpPut(nameof(UpdateProduct))]
        public IActionResult UpdateProduct(Product product)
        {
            productService.UpdateProduct(product);
            return Ok("Data Updated");
        }

        [HttpDelete(nameof(DeleteProduct))]
        public IActionResult DeleteProduct(int id) 
        {
            productService.DeleteProduct(id);
            return Ok("Deleted");
        }

     /*
    [HttpGet]
        public List<ProductDetails> Get()
        {
            List<ProductDetails> productDetails = new List<ProductDetails>();
            var prodcutList = productService.GetProduct().ToList();
            foreach (var product in prodcutList)
            {
                var productDetailList = productDetailsService.GetProductDetail(product.ProductID);
                ProductDetails details = new ProductDetails
                {
                    ProductID = product.ProductID,
                    //ProductName = product.ProductName,
                    Price = productDetailList.Price,
                    StockAvailable = productDetailList.StockAvailable,
                };
                productDetails.Add(details);
            }
            return productDetails;
        }*/
    }
}
