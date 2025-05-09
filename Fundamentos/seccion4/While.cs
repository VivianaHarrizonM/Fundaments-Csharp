using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.seccion4
{
    internal class While
    {
        static void Main(string[] args)
        {
            /*            byte numero = 1;

                        while (numero <= 10)
                        {
                            Console.WriteLine(numero);
                            numero++;
                        }*/

            //String contraseña1, contraseña2 = " ";

            //Console.Write("Escribe tu contraseña: ");
            //contraseña1 = Console.ReadLine();

            //while (contraseña1 != contraseña2)
            //{
            //    Console.Write("Confirma tu contraseña: ");
            //    contraseña2 = Console.ReadLine();
            //}
            //Console.WriteLine("Contraseña guardada");

            Console.WriteLine(" --------------- Do while ------------------------");
            //int i = 1;

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //while (i <= 10);

            decimal num1, num2, resultado = 0M;
            byte opcion;


            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");

                Console.Write("Elige una opcion: ");
                opcion = Convert.ToByte(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));

            Console.Write("Dame el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dame el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num1 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Divisor no valido");
                    }
                    break;

            }
            Console.WriteLine("El resultado de tu operacion es: {0}", resultado);

            int i, j, resul;
            for (i = 1; i <= 10; i++)
                Console.WriteLine("Tabla de multiplicar del {0}", i);
            {
                for (j = 1; j <= 10; j++)
                {
                    resul = i * j;
                    Console.WriteLine("{0} * {1} = {2}", i,j, resul);
                }
            }
                
        }

        

    }
}
