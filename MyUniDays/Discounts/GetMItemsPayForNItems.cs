using System;
using MyUniDays.Interfaces;

namespace MyUniDays.Discounts
{

        public class GetMItemsPayForNItems: IDiscountPrice
        {
            private int getMItems;
            private int payForNItems;

            public GetMItemsPayForNItems(int getMItems, int payForNItems)
            {
                this.getMItems = getMItems;
                this.payForNItems = payForNItems;
            }

            public decimal GetDiscountPrice(int quantity, decimal unitPrice)
            {
                return unitPrice * (Math.Floor((decimal)quantity / getMItems) * payForNItems + quantity % getMItems);
            }
        }
    }

