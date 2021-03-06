
using System;
using System.Collections.Generic;
using System.Text;
using TestMyClean.Core.Entities.OrderAggregate;
using TestMyClean.SharedKernel;

namespace TestMyClean.Core.Entities
{
    public class OrderItem : BaseEntity
    {

        public CatalogItemOrdered ItemOrdered { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int Units { get; private set; }

        private OrderItem()
        {
            // required by EF
        }

        public OrderItem(CatalogItemOrdered itemOrdered, decimal unitPrice, int units)
        {
            ItemOrdered = itemOrdered;
            UnitPrice = unitPrice;
            Units = units;
        }
    }
}
