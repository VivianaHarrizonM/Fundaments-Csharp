using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.seccion4
{
    internal class tarea4
    {
        static void Main(string[] args)
        {
            //Calcular la potencia de un número ya sea positiva o negativa y 0

            double baseNum;
            int exponente;
            double resultado = 1;

            Console.Write("Dame un número base: ");
            baseNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame un número exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            // Manejar exponente positivo
            for (int i = 1; i <= exponente; i++)
            {
                resultado *= baseNum;
            }

            // Manejar exponente cero
            for (int i = 0; i == 0 && exponente == 0; i++) // entra solo si exponente == 0
            {
                resultado = 1;
            }

            // Manejar exponente negativo
            for (int i = 1; i <= -exponente; i++) // se ejecuta solo si exponente < 0
            {
                resultado *= baseNum;
            }
            for (int i = 0; i == 0 && exponente < 0; i++) // entra una sola vez si exponente < 0
            {
                resultado = 1 / resultado;
            }

            Console.WriteLine("{0} ^ {1} = {2}", baseNum, exponente, resultado);


            //Devolvemos los numeros primos del 1 al 100
            Console.WriteLine("--------------Números primos del 1 al 100 -----------------------");

            for (int i = 2; i <= 100; i++) 
            {
                if (EsPrimo(i))
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine(); 
        }

        static bool EsPrimo(int numero)
        {
            if (numero < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}
