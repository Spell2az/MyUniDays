using System;
using MyUniDays.Interfaces;

namespace MyUniDays.Discounts
{

        public class GetMForNItems:  IDiscountPrice
        {
            private int m;
            private int n;

            public GetMForNItems(int m, int n)
            {
                this.m = m;
                this.n = n;
            }

            public decimal GetDiscountPrice(int quantity, decimal unitPrice)
            {
                return unitPrice * ((decimal) (Math.Floor((double)quantity / m) * n) + quantity % m);
            }
        }
    }

