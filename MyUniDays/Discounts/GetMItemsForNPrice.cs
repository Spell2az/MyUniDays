using System;
using MyUniDays.Interfaces;

namespace MyUniDays.Discounts
{
    public class GetMItemsForNPrice : IDiscountPrice
    {
        private int getMItems;
        private decimal payNPrice;

        public GetMItemsForNPrice(int getMItems, decimal payNPrice)
        {
            this.getMItems = getMItems;
            this.payNPrice = payNPrice;
        }

        public decimal GetDiscountPrice(int quantity, decimal unitPrice)
        {
            return (Math.Floor((decimal)quantity / getMItems) * payNPrice) + (quantity % getMItems) * unitPrice;
        }
    }
    }

