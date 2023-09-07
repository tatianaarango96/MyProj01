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
//Ejercicio 2  Double or Tripl
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
//Ejercicio 3 Root or Squar
// Pide al usuario un número. Si es positivo, devuelve su raíz 
//cuadrada, de lo contrario, devuelve su cuadrado. 
Console.Write("Ingresa un número: ");
               if (double.TryParse(Console.ReadLine(), out double numero3))
            {
               if (numero3 > 0)
           {
               double resultado3 = Math.Sqrt(numero3);
               Console.WriteLine($"Resultado: {resultado3}");
               }
               else
             {
             double resultado3 = Math.Pow(numero3, 2);
             Console.WriteLine($"Resultado: {resultado3}");
              }
              }
             else
             {
             Console.WriteLine("Entrada no válida. Ingresa un número válido.");
}
//Ejercicio 4  Circle Perimeter
//Pide al usuario el radio de un círculo y using System;
{
        double radio;

        Console.Write("Ingresa el radio del círculo: ");
        if (double.TryParse(Console.ReadLine(), out radio))
        {
            if (radio >= 0)
            {
                double perimetro = 2 * Math.PI * radio;
                Console.WriteLine($"El perímetro del círculo es: {perimetro}");
            }
            else
            {
                Console.WriteLine("El radio no puede ser negativo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Ingresa un valor numérico para el radio.");
        }

        Console.ReadLine();
    }
