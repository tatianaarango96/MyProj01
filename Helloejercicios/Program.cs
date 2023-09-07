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
// Ejercicio 2  Double or Tripl
// Solicita al usuario dos números. Si el primero es mayor, devuelva 
//su doble, de lo contrario devuelva el triple del segundo. 
 Console.Write("Ingresa el primer número: ");
if (double.TryParse(Console.ReadLine(), out double numero1))
{
    Console.Write("Ingresa el segundo número: ");
    if (double.TryParse(Console.ReadLine(), out double numero2))
    {
        double resultado = (numero1 > numero2) ? numero1 * 2 : numero2 * 3;
        Console.WriteLine($"Resultado: {resultado}");
    }
    else
    {
        Console.WriteLine("Entrada no válida para el segundo número.");
    }
}
else
{
    Console.WriteLine("Entrada no válida para el primer número.");
}
