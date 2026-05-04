public class Producto
{
    public string Descripcion { get; set; }
    
    public void ModificarDescripcion(string nuevaDescripcion)
    {
        Descripcion = nuevaDescripcion;
    }
}

public class Problema3
{
    public string CompararCopias(int originalValue, Producto product)
    {
        // 1. Copiar originalValue en una variable local
        int copiaValor = originalValue;
        
        // 2. Incrementar solo la copia
        copiaValor++;
        
        // 3. Copiar la referencia de product en otra variable local
        Producto copiaProducto = product;
        
        // 4. Modificar la descripción del producto copiado
        copiaProducto.ModificarDescripcion("Descripción modificada");
        
        // 5. Retornar cadena con el formato
        return $"{originalValue}-{copiaValor}-{product.Descripcion}";
    }
}