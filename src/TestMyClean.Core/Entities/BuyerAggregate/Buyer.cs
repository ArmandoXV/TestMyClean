using System;
using System.Collections.Generic;
using System.Text;
using TestMyClean.Core.Entities.BasketAggregate;
using TestMyClean.SharedKernel;

namespace TestMyClean.Core.Entities.BuyerAggregate
{
    public class Buyer : BaseEntity
    {
        public string PaymentMethod { get; set; }

        public Basket Basket { get; set; }

    }
}
