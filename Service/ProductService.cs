using System;
using System.Collections.Generic;
using System.Text;
using Repository;
using Domain;

namespace Service
{
    public class ProductService : IProductService
    {
        private IRepository<Product> productRepository;
        private IRepository<ProductDetails> productDetailRepository;

        public ProductService(IRepository<Product> productRepository, IRepository<ProductDetails> productDetailRepository)
        {
            this.productRepository = productRepository;
            this.productDetailRepository = productDetailRepository;
        }

        public void DeleteProduct(int id)
        {
            Product product = GetProduct(id);
            productRepository.Remove(product);
            productRepository.SaveChanges();
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return productRepository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return productRepository.Get(id);
        }

        public void InsertProduct(Product _product)
        {
            productRepository.Insert(_product);
        }

        public void UpdateProduct(Product _product)
        {
            productRepository.Update(_product);
        }
    }
}
