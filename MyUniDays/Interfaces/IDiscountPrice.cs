namespace MyUniDays.Interfaces
{
    public interface IDiscountPrice
    {
        decimal GetDiscountPrice(int quantity, decimal unitPrice);
    }
}