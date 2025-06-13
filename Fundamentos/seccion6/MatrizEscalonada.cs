using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.seccion6
{
    internal class MatrizEscalonada
    {/*
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
            //int i;
            //int j;
            //double[][] ventas = new double[4][]
            //    {
            //        new double[] { 155, 100, 170 },
            //        new double[] { 206, 120 },
            //        new double[] { 115, 190, 104, 130 },
            //        new double[] { 163, 218, 125 }

            //    };
            //for (i = 0; i < ventas.Length; i++)
            //{
            //    Console.WriteLine("Elemento: {0}", i);
            //    for (j = 0; j < ventas[i].Length; j++)
            //    {
            //        Console.WriteLine(ventas[i][j]);
            //    }
            //}

            byte i, j, numCal, alumnos;
            double sumaTotal = 0, promedio, califMin = 10, califMax = 0;
            int totalCalificaciones = 0;

            Console.Write("Ingresa el número de alumnos: ");
            alumnos = Convert.ToByte(Console.ReadLine());

            double[][] calificaciones = new double[alumnos][];

            for (i = 0; i < alumnos; i++)
            {
                Console.Write($"Ingresa el número de calificaciones para el alumno {i + 1}: ");
                numCal = Convert.ToByte(Console.ReadLine());
                calificaciones[i] = new double[numCal];
            }

            // Ingreso de calificaciones
            for (i = 0; i < alumnos; i++)
            {
                Console.WriteLine($"\nAlumno {i + 1}:");
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.Write($"  Ingresa la calificación #{j + 1}: ");
                    double calif = Convert.ToDouble(Console.ReadLine());

                    calificaciones[i][j] = calif;
                    sumaTotal += calif;
                    totalCalificaciones++;

                    if (calif < califMin) califMin = calif;
                    if (calif > califMax) califMax = calif;
                }
            }

            promedio = sumaTotal / totalCalificaciones;

            // Resultados
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Promedio general: {promedio:F2}");
            Console.WriteLine($"Calificación máxima: {califMax}");
            Console.WriteLine($"Calificación mínima: {califMin}");

        }*/
    }
}
