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
//Ejercicio 5 Midweek Day   
//Solicita al usuario un número entre 1 y 7 y muestra el día de la 
//semana correspondiente, pero solo considerando los días laborables. 
    {
        Console.Write("Ingresa un número del 1 al 7: ");
        if (int.TryParse(Console.ReadLine(), out int número))
        {
            switch (número)
            {
                case 1:
                    Console.WriteLine("Lunes (Laborable)");
                    break;
                case 2:
                    Console.WriteLine("Martes (Laborable)");
                    break;
                case 3:
                    Console.WriteLine("Miércoles (Laborable)");
                    break;
                case 4:
                    Console.WriteLine("Jueves (Laborable)");
                    break;
                case 5:
                    Console.WriteLine("Viernes (Laborable)");
                    break;
                default:
                    Console.WriteLine("Día no laborable o número fuera de rango.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Ingresa un número válido.");
        }

        Console.ReadLine();
    }
//Ejercicio 6 Tax Calculator 
//Solicita al usuario su salario anual y, si este excede los 12000, 
//muestra el impuesto a pagar que es el 15% del excedente. 
{
        Console.Write("Ingresa tu salario anual: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal salarioAnual))
        {
            decimal salarioMinimo = 12000m;

            if (salarioAnual > salarioMinimo)
            {
                decimal excedente = salarioAnual - salarioMinimo;
                decimal impuesto = 0.15m * excedente;

                Console.WriteLine($"Tu salario anual excede los {salarioMinimo:C}.");
                Console.WriteLine($"Impuesto a pagar: {impuesto:C}");
            }
            else
            {
                Console.WriteLine("Tu salario anual no excede los 12,000. No tienes que pagar impuesto.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Ingresa un valor numérico para el salario anual.");
        }

        Console.ReadLine();
    }
//Ejercicio 7 Remainder Finder 
//Solicita dos números y muestra el residuo de la división del 
//primero entre el segundo. 
{
        Console.Write("Ingresa el primer número: ");
        if (double.TryParse(Console.ReadLine(), out double número1))
        {
            Console.Write("Ingresa el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out double número2))
            {
                if (número2 != 0)
                {
                    double residuo = número1 % número2;
                    Console.WriteLine($"El residuo de {número1} entre {número2} es: {residuo}");
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero. Ingresa un segundo número diferente de cero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida para el segundo número. Ingresa un valor numérico.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida para el primer número. Ingresa un valor numérico.");
        }

        Console.ReadLine();
    }
 //Ejercicio 8 Sum of Evens
//Calcula y muestra la suma de los números pares entre 1 y 50 
{
        int suma = 0;

        for (int i = 2; i <= 50; i += 2)
        {
            suma += i;
        }

        Console.WriteLine($"La suma de los números pares entre 1 y 50 es: {suma}");
        Console.ReadLine();
    }
 //Ejercicio 9 Fraction Difference
//Solicita al usuario los valores para dos fracciones y muestra la 
//diferencia entre esas fracciones. 
    {
        Console.Write("Ingresa el numerador de la primera fracción: ");
        if (int.TryParse(Console.ReadLine(), out int numerador1))
        {
            Console.Write("Ingresa el denominador de la primera fracción (distinto de cero): ");
            if (int.TryParse(Console.ReadLine(), out int denominador1) && denominador1 != 0)
            {
                Console.Write("Ingresa el numerador de la segunda fracción: ");
                if (int.TryParse(Console.ReadLine(), out int numerador2))
                {
                    Console.Write("Ingresa el denominador de la segunda fracción (distinto de cero): ");
                    if (int.TryParse(Console.ReadLine(), out int denominador2) && denominador2 != 0)
                    {
                        // Calcular la diferencia de fracciones
                        int nuevoDenominadorComun = denominador1 * denominador2;
                        int nuevoNumerador1 = numerador1 * denominador2;
                        int nuevoNumerador2 = numerador2 * denominador1;

                        int diferenciaNumerador = nuevoNumerador1 - nuevoNumerador2;

                        Console.WriteLine($"La diferencia de las fracciones {numerador1}/{denominador1} y {numerador2}/{denominador2} es: {diferenciaNumerador}/{nuevoDenominadorComun}");
                    }
                    else
                    {
                        Console.WriteLine("El denominador de la segunda fracción debe ser un número válido y distinto de cero.");
                    }
                }
                else
                {
                    Console.WriteLine("El numerador de la segunda fracción debe ser un número válido.");
                }
            }
            else
            {
                Console.WriteLine("El denominador de la primera fracción debe ser un número válido y distinto de cero.");
            }
        }
        else
        {
            Console.WriteLine("El numerador de la primera fracción debe ser un número válido.");
        }

        Console.ReadLine();
    }

//Ejercicio String Length
//Pide una palabra al usuario y muestra la longitud de esa palabra. 
 Console.Write("Ingrese una palabra: ");
            string? palabra = Console.ReadLine();

            if (!string.IsNullOrEmpty(palabra))
            {
                int longitud = palabra.Length;
                Console.WriteLine($"Resultado: {longitud}");
            }
            else
            {
                Console.WriteLine("La entrada no puede estar vacía.");
            }

            Console.WriteLine("Ingrese cuatro números para calcular su promedio:");

