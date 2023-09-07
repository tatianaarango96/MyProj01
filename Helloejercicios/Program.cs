// Ejercicio 1 Positive Power 
// Solicita al usuario un número y eleva este número al cuadrado.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
        }

        static void Ejercicio1()
        {
            Console.Write("Ingresa un número: ");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                string resultado = (numero > 0) ? Math.Pow(numero, 2).ToString() : (numero < 0) ? "Número negativo." : "0";
                Console.WriteLine($"Resultado: {resultado}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingresa un número válido.");
            }
        }

        static void Ejercicio2()
        {
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
        }

        static void Ejercicio3()
        {
            Console.Write("Ingresa un número: ");
            if (double.TryParse(Console.ReadLine(), out double numero3))
            {
                double resultado = (numero3 > 0) ? Math.Sqrt(numero3) : Math.Pow(numero3, 2);
                Console.WriteLine($"Resultado: {resultado}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingresa un número válido.");
            }
        }
    }
}