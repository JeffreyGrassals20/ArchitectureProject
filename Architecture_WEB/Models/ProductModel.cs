using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture_WEB.Models
{
    public class ProductModel : BaseEntityModel
    {
        public string ProductName { get; set; }
        public virtual ProductDetailModel ProductDetailsModel { get; set; }
    }
}
