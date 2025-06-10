using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.seccion6
{
    internal class MatrizEscalonada
    {
        static void Main(string[] args)
        {
            //int[] numeros = new int[4] { 23, 13, 5, 6 };

            //Console.WriteLine(numeros.Length);
            //double[,] ventas = new double[4, 3]
            //    {
            //        { 155, 100, 170 },
            //        { 206, 120 , 130},
            //        { 115, 190, 104 },
            //        { 163, 218, 125 }

            //    };
            //Console.WriteLine(ventas.Length);

            //double[][] ventas = new double[4][];

            //ventas[0] = new double[3] { 155, 100, 170};
            //ventas[1] = new double[2] { 206, 120 };
            //ventas[2] = new double[4] { 115,190, 104, 130};
            //ventas[3] = new double[3] { 163, 218,125};
            int i;
            int j;
            double[][] ventas = new double[4][]
                {
                    new double[] { 155, 100, 170 },
                    new double[] { 206, 120 },
                    new double[] { 115, 190, 104, 130 },
                    new double[] { 163, 218, 125 }

                };
            for (i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine("Elemento: {0}", i);
                for (j = 0; j < ventas[i].Length; j++)
                {
                    Console.WriteLine(ventas[i][j]);
                }
            }


        }
    }
}
