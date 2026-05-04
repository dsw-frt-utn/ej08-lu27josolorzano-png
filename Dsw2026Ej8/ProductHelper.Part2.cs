public partial class ProductHelper
{
    public string ObtenerEtiquetaProducto(long code, string description, decimal price)
    {
        return $"[{code}] {description} - {price.ToString(FormatoMoneda)}";
    }
}