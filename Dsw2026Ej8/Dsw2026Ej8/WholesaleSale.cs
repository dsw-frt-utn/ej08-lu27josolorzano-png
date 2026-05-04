public class WholesaleSale : Sale
{
    public override decimal CalculateTotal()
    {
        return Amount * 0.9m; // 10% descuento
    }
}