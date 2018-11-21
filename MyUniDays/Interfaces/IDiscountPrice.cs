namespace MyUniDays.Interfaces
{
    public interface IDiscountPrice
    {
        decimal GetDiscountPrice(decimal price, int quantity);
    }
}