using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.seccion5
{
    internal class Metodos
    /* Tipos de métodos
     * 1. Métodos sin parametros ni tipos
     * 2. Métodos con párametros
     * 3. Métodos que devuelven un tipo
     * 4. Métodos con párametros y que devuelven un tipo
     */
    {/*
        static void Main(string[] args)
        {
            int opcion;
            decimal num1, num2;
            decimal resultado = 0;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");

                Console.Write("Elige una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));

            Console.Write("Dame el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = Sumar(num1, num2);
                    break;
                case 2:
                    resultado = Restar(num1, num2);
                    break;
                case 3:
                    resultado = Multiplicar(num1, num2);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = Dividir(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero.");
                        return;
                    }
                    break;
            }

            Console.WriteLine("El resultado de tu operación es: {0}", resultado);
        }*/

        // Métodos con parámetros y retorno
        static decimal Sumar(decimal a, decimal b) => a + b;
        static decimal Restar(decimal a, decimal b) => a - b;
        static decimal Multiplicar(decimal a, decimal b) => a * b;
        static decimal Dividir(decimal a, decimal
            
            
            b) => a / b;
    }
}
        
      
