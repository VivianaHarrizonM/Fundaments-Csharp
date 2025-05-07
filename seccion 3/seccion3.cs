using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.seccion_3
{
    internal class seccion3
    {
        /*
        static void Main(string[] args)
        {
            /*
            string color;

            Console.Write("Ingresa el color RGB para darte su código: ");
            color = Console.ReadLine();

            switch (color)//Expresion de coincidencia)
            {
                case "Red":
                case "red":
                case "RED":
                    Console.WriteLine("El código RGB para {0} es: 255, 0 ,0 ", color);
                    break;
                case "Green":
                case "green":
                case "GREEN":
                    Console.WriteLine("El código RGB para {0} es: 0, 255 ,0 ", color);
                    break;
                case "Blue":
                case "blue":
                case "BLUE":
                    Console.WriteLine("El código RGB para {0} es: 0, 0 ,255 ", color);
                    break;
                default: Console.WriteLine("No se encontró el código rgb para el color: {0} intenta de nuevo", color);
                    break;*/

            // ********** Se necesita un programa que realice las 4 operaciones básicas: suma, resta, multiplicación y división, a partir de dos numeros, la operación deseada será elejifa por el usuario. *************
            /*
            // Variables
            // Variables
            decimal num1, num2, resultado = 0;
            byte opcion;

            // Mostramos el menú
            Console.WriteLine("\n--- Calculadora ---");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");

            Console.Write("Elige una opción: ");
            if (!byte.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                Console.WriteLine("⚠️ Ingresa una opción válida entre 1 y 5.");
                return; // Sale del programa si la opción no es válida
            }

            if (opcion == 5)
            {
                Console.WriteLine("Saliendo del programa... ¡Hasta luego!");
                return; // Sale del programa si elige la opción 5
            }

            // Pedimos los números
            Console.Write("Dame el primer número: ");
            if (!decimal.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("⚠️ Error: Ingresa un número válido.");
                return; // Sale si el primer número no es válido
            }

            Console.Write("Dame el segundo número: ");
            if (!decimal.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("⚠️ Error: Ingresa un número válido.");
                return; // Sale si el segundo número no es válido
            }

            // Realizamos la operación según la opción
            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado de la división es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("⚠️ No es posible dividir entre cero.");
                    }
                    break;
            }

        }*/
    }

}
