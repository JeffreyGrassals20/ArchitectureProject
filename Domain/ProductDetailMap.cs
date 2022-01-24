using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class ProductDetailMap
    {
        public ProductDetailMap(EntityTypeBuilder<ProductDetails> entityBuilder)
        {
            entityBuilder.HasKey(p => p.ProductID);
            entityBuilder.Property(p => p.StockAvailable);
            entityBuilder.Property(p => p.Price);
        }

    }
}
