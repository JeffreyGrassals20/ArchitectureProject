using System;
using System.Collections.Generic;
using System.Text;
using Domain;
namespace Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProduct(int id);

        void InsertProduct(Product _product);
        void UpdateProduct(Product _product);
        void DeleteProduct(int id);
    }
}
