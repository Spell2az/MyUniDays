using System;
using MyUniDays;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class UnidaysDiscountChallengeTests
    {
        [Test]
        public void AddToBasketTest()
        {
            var discounts = new UnidaysDiscountChallenge();

            discounts.AddToBasket('A');
            discounts.AddToBasket('A');

            Assert.IsTrue(discounts.Basket['A'] == 2);
        }
    }
}
