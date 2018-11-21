using System;
using MyUniDays.Interfaces;

namespace MyUniDays.Discounts
{
    public class GetMItemsForNPrice : IDiscountPrice
    {
        private int m;
        private decimal n;

        public GetMItemsForNPrice(int m, decimal n)
        {
            this.m = m;
            this.n = n;
        }

        public decimal GetDiscountPrice(decimal price, int quantity)
        {
            return (Math.Floor((decimal) quantity / m) * n) + (quantity % m) * price;
        }
    }
    }

