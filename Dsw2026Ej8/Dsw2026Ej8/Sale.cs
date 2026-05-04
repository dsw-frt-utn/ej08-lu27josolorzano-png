public class Sale
{
    public decimal Amount { get; set; }
    
    public virtual decimal CalculateTotal()
    {
        return Amount;
    }
}