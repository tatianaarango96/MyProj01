// Ejercicio 1 Positive Power 
// Solicita al usuario un número y eleva este número al cuadrado.
Console.Write("Ingresa un número: ");
if (double.TryParse(Console.ReadLine(), out double numero))
{
    double resultado;

    if (numero > 0)
    {
        resultado = Math.Pow(numero, 2);
    }
    else if (numero < 0)
    {
        resultado = numero;
    }
    else
    {
        resultado = 0;
    }

    Console.WriteLine($"Resultado: {resultado}");
}
else
{
    Console.WriteLine("Entrada no válida. Ingresa un número válido.");
}