using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.seccion5
{
    internal class Tarea5Parte2
    {
       static void Main(string[] args)
        {

            //Crea una aplicación que calcule el área de un circulo, cuadrado o triangulo.
            //Preguntando al usuario a que figura le quiere calcular el área y dependiendo del caso ejecutar el método respectivo

            int opcion;
            double resultado;

            do
            {
                Console.WriteLine("\n--- Calculadora de Áreas ---");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("❌ Entrada inválida. Ingresa un número.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        resultado = CalcularAreaCirculo();
                        Console.WriteLine($"Área del círculo: {resultado:F2}");
                        break;

                    case 2:
                        resultado = CalcularAreaCuadrado();
                        Console.WriteLine($"Área del cuadrado: {resultado:F2}");
                        break;

                    case 3:
                        resultado = CalcularAreaTriangulo();
                        Console.WriteLine($"Área del triángulo: {resultado:F2}");
                        break;

                    case 4:
                        Console.WriteLine("👋 Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("❌ Opción inválida. Intenta de nuevo.");
                        break;
                }

            } while (opcion != 4);
        }

        static double CalcularAreaCirculo()
        {
            double radio = PedirValorPositivo("Introduce el radio del círculo: ");
            return Math.PI * Math.Pow(radio, 2);
        }

        static double CalcularAreaCuadrado()
        {
            double lado = PedirValorPositivo("Introduce el lado del cuadrado: ");
            return lado * lado;
        }

        static double CalcularAreaTriangulo()
        {
            double baseTriangulo = PedirValorPositivo("Introduce la base del triángulo: ");
            double altura = PedirValorPositivo("Introduce la altura del triángulo: ");
            return (baseTriangulo * altura) / 2;
        }

        static double PedirValorPositivo(string mensaje)
        {
            double valor;
            do
            {
                Console.Write(mensaje);
                if (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
                {
                    Console.WriteLine("❌ Por favor, ingresa un número positivo válido.");
                }
            } while (valor <= 0);
            return valor;
        }
    }
}
