using System;
using System.Collections.Generic;
using System.Text;
using Repository;
using Domain;
namespace Service
{
    public class ProductDetailService : IProductDetailsService
    {
        private IRepository<ProductDetails> productDetailsRepository;

        public ProductDetailService(IRepository<ProductDetails> productDetailsRepository)
        {
            this.productDetailsRepository = productDetailsRepository;
        }

        public void DeleteProductDetail(int id)
        {
            throw new NotImplementedException();
        }

        public ProductDetails GetProductDetail(int id)
        {
            return productDetailsRepository.Get(id);
        }

        public void InsertProductDetail(ProductDetails _productDetail)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductDetail(ProductDetails _productDetail)
        {
            throw new NotImplementedException();
        }
    }
}
