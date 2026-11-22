using System;
using System.Globalization;

namespace ActividadControlFlujo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Algoritmos Computacionales - Actividad 2";
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                MostrarMenu();
                Console.Write("Seleccione una opción: ");
                string? opcion = Console.ReadLine();

                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        double baseTriangulo = LeerDoublePositivo("Ingrese la base del triángulo: ");
                        double alturaTriangulo = LeerDoublePositivo("Ingrese la altura del triángulo: ");
                        double areaTriangulo = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                        Console.WriteLine($"El área del triángulo es: {areaTriangulo:F2}");
                        break;

                    case "2":
                        double ladoCuadrado = LeerDoublePositivo("Ingrese el lado del cuadrado: ");
                        double areaCuadrado = CalcularAreaCuadrado(ladoCuadrado);
                        Console.WriteLine($"El área del cuadrado es: {areaCuadrado:F2}");
                        break;

                    case "3":
                        double radioCirculo = LeerDoublePositivo("Ingrese el radio del círculo: ");
                        double areaCirculo = CalcularAreaCirculo(radioCirculo);
                        Console.WriteLine($"El área del círculo es: {areaCirculo:F2}");
                        break;

                    case "4":
                        int edad = LeerEnteroNoNegativo("Ingrese la edad: ");
                        string resultadoEdad = EvaluarEdad(edad);
                        Console.WriteLine(resultadoEdad);
                        break;

                    case "0":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey(true);
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Calcular área de un triángulo");
            Console.WriteLine("2. Calcular área de un cuadrado");
            Console.WriteLine("3. Calcular área de un círculo");
            Console.WriteLine("4. Verificar si es mayor o menor de edad");
            Console.WriteLine("0. Salir");
            Console.WriteLine("======================");
        }

        static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo) / 2.0;
        }

        static double CalcularAreaCuadrado(double lado)
        {
            return lado * lado;
        }

        static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        static string EvaluarEdad(int edad)
        {
            return edad >= 18
                ? $"Con {edad} años, la persona es MAYOR de edad."
                : $"Con {edad} años, la persona es MENOR de edad.";
        }

        static double LeerDoublePositivo(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string? entrada = Console.ReadLine()?.Replace(',', '.');
                if (double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out double valor) && valor > 0)
                {
                    return valor;
                }
                Console.WriteLine("Entrada inválida. Ingrese un número mayor que cero.");
            }
        }

        static int LeerEnteroNoNegativo(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string? entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int valor) && valor >= 0)
                {
                    return valor;
                }
                Console.WriteLine("Entrada inválida. Ingrese un número entero igual o mayor que cero.");
            }
        }
    }
}