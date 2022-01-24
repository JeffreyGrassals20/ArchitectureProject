using System;
using System.Collections.Generic;
using System.Text;
using Domain;
namespace Service
{
   public interface IProductDetailsService
    {
        Domain.ProductDetails GetProductDetail(int id);

        void InsertProductDetail(ProductDetails _productDetail);
        void UpdateProductDetail(ProductDetails _productDetail);
        void DeleteProductDetail(int id);
    }
}
