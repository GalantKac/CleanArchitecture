using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entity
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
    }
}
