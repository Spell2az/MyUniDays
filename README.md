# MyUniDays - Tech Challenge

## To Run

Open solution in Visual Studio 2017, and from Test menu select Run > All Tests.

## Approach

After reading instructions it became clear to me, that I want my implementation to be flexible in terms of discounts and I found that to be the most challenging part. I explored different approaches until I was satisfied. I wanted to avoid hardcoding discounts into their respective methods and make it easier to make new discounts (e.g. Buy 5 for price of 3, Buy 4 for price of 15 etc. which is accomplished by pricing rule taking IDiscountPrice type as a parameter) and also adding new kinds of discounts easier if necessary for example get 50% off of every third items, for that all that's needed is to add new class implementing IDiscountPrice interface and creating and adding new pricing rule. My aim was also to make classes api's easy to use. AddToBasketBulk method was added to make it easier to test pricing with different item combinations and for same reason I added test project to solution. Tests helped me with refactoring and provided immediate feedback if any of the changes broke my code.

To summarize, I started with the outline and thought about the classes that will be needed, how to store added items, how to represent discount and how to make discounts flexible.
