public static class Extensions
{
    public static string ToProductCode(this string code)
    {
        if (code == null)
            return "SIN-CODIGO";
        
        // Eliminar espacios al inicio y al final
        string resultado = code.Trim();
        
        // Convertir a mayúsculas
        resultado = resultado.ToUpper();
        
        // Reemplazar espacios internos por guiones
        resultado = resultado.Replace(' ', '-');
        
        return resultado;
    }
}