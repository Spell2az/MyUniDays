namespace MyUniDays.Interfaces
{
    public interface IGetDiscount
    {
        decimal CalculateDiscount(decimal price, int quantity);
    }
}