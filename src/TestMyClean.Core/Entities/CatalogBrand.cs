using System;
using System.Collections.Generic;
using System.Text;
using TestMyClean.SharedKernel;

namespace TestMyClean.Core.Entities
{
    public class CatalogBrand : BaseEntity
    {
        public string Brand { get; private set; }
        public CatalogBrand(string brand)
        {
            Brand = brand;
        }
    }
}
