public class Problema4
{
    public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
    {
        int suma = 0;
        int contador = 0;
        
        // Validar y sumar nota1
        if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10)
        {
            suma += nota1.Value;
            contador++;
        }
        
        // Validar y sumar nota2
        if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10)
        {
            suma += nota2.Value;
            contador++;
        }
        
        // Validar y sumar nota3
        if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10)
        {
            suma += nota3.Value;
            contador++;
        }
        
        // Si no hay notas válidas, retornar 0
        if (contador == 0)
            return 0;
        
        return (double)suma / contador;
    }
}