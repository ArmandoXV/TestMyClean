using System;
using System.Collections.Generic;
using System.Text;
using TestMyClean.SharedKernel;

namespace TestMyClean.Core.Entities
{
    public class CatalogType : BaseEntity
    {
        public string Type { get; private set; }
        public CatalogType(string type)
        {
            Type = type;
        }
    }
}
