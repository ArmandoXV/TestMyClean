using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Text;
using TestMyClean.SharedKernel;

namespace TestMyClean.Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public int BuyerID { get; private set; }
        public DateTimeOffset OrderDate { get; private set; } = DateTimeOffset.Now;
        public Address ShipToAddress { get; private set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        private Order()
        {
            // required by EF
        }

        public Order(int buyerId, Address shipToAddress, ICollection<OrderItem> items)
        {
            
            Guard.Against.Null(shipToAddress, nameof(shipToAddress));
            Guard.Against.Null(items, nameof(items));

            BuyerID = buyerId;
            ShipToAddress = shipToAddress;
            OrderItems = items;
        }

        public decimal Total()
        {
            var total = 0m;
            foreach (var item in OrderItems)
            {
                total += item.UnitPrice * item.Units;
            }
            return total;
        }


    }
}
