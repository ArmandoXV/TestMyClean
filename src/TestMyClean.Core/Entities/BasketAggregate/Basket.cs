using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestMyClean.Core.Entities.BuyerAggregate;
using TestMyClean.SharedKernel;

namespace TestMyClean.Core.Entities.BasketAggregate
{
    public class Basket : BaseEntity
    {
        
        public int BuyerForeignKey { get; set; }
        public Buyer Buyer { get; set; }

        public ICollection<BasketItem> BasketItems { get; set; }

        public Basket()
        {
        }

        public void AddItem(int catalogItemId, decimal unitPrice, int quantity = 1)
        {
            if (!BasketItems.Any(i => i.CatalogItemId == catalogItemId))
            {
                BasketItems.Add(new BasketItem(catalogItemId, quantity, unitPrice));
                return;
            }
            var existingItem = BasketItems.FirstOrDefault(i => i.CatalogItemId == catalogItemId);
            existingItem.AddQuantity(quantity);
        }
    }
}
