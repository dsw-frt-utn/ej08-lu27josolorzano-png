public class RetailSale : Sale
{
    public override decimal CalculateTotal()
    {
        return Amount;
    }
}