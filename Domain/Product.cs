using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public virtual ProductDetails ProductDetails { get; set; }
    }
}
