using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.seccion6
{
    internal class Tarea6
    {
        static void Main(string[] args)
        {
            //byte numAlumnos;
            //Console.Write("Ingrese el número de alumnos: ");
            //numAlumnos = Convert.ToByte(Console.ReadLine());

            //double[][] calificaciones = new double[numAlumnos][];

            //for (int i = 0; i < numAlumnos; i++)
            //{
            //    Console.Write($"\nIngrese el número de calificaciones para el alumno {i + 1}: ");
            //    byte numCalificaciones = Convert.ToByte(Console.ReadLine());
            //    calificaciones[i] = new double[numCalificaciones];
            //}

            //Console.Clear();
            //Console.WriteLine("===== Ingreso de calificaciones =====\n");

            //double sumaGeneral = 0;
            //int totalCalificaciones = 0;

            //for (int i = 0; i < numAlumnos; i++)
            //{
            //    Console.WriteLine($"Alumno {i + 1}:");

            //    double sumaAlumno = 0;
            //    double califMin = 10;
            //    double califMax = 0;

            //    for (int j = 0; j < calificaciones[i].Length; j++)
            //    {
            //        Console.Write($"  Calificación #{j + 1}: ");
            //        double calif = Convert.ToDouble(Console.ReadLine());

            //        calificaciones[i][j] = calif;
            //        sumaAlumno += calif;
            //        sumaGeneral += calif;
            //        totalCalificaciones++;

            //        if (calif < califMin) califMin = calif;
            //        if (calif > califMax) califMax = calif;
            //    }

            //    double promedioAlumno = sumaAlumno / calificaciones[i].Length;

            //    Console.WriteLine($"\n  -> Promedio del alumno {i + 1}: {promedioAlumno:F2}");
            //    Console.WriteLine($"  -> Calificación mínima: {califMin}");
            //    Console.WriteLine($"  -> Calificación máxima: {califMax}");
            //    Console.WriteLine(new string('-', 35));
            //}

            //double promedioGeneral = sumaGeneral / totalCalificaciones;

            //Console.WriteLine("\n===== Resultados Generales =====");
            //Console.WriteLine($"Promedio general del grupo: {promedioGeneral:F2}");

            //++++++++++++++++ Tarea resuelta profe++++++++++++++++++++++++++++++

            byte i, j, numCal, alumnos;
            double sumaCalif = 0, sumaCalifAlumno, totalAlumnos = 0, promedio, califMin = 10, califMax = 0;

            Console.Write("Ingresa el número de alumnos: ");
            alumnos = Convert.ToByte(Console.ReadLine());

            double[][] calificaciones = new double[alumnos][];

            for (i = 0; i < alumnos; i++)
            {
                Console.Write($"\nIngresa el número de calificaciones para el alumno {i + 1}: ");
                numCal = Convert.ToByte(Console.ReadLine());
                totalAlumnos += numCal;
                calificaciones[i] = new double[numCal];
            }

            double[] califMinAlum = new double[alumnos];
            double[] califMaxAlum = new double[alumnos];
            double[] promedioAlum = new double[alumnos];

            // Ingreso de calificaciones
            for (i = 0; i < alumnos; i++)
            {
                sumaCalifAlumno = 0;
                califMax = 0;
                califMin = 10;

                Console.WriteLine($"\nAlumno {i + 1}:");
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.Write($"  Ingresa la calificación #{j + 1}: ");
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                    sumaCalif += calificaciones[i][j];
                    sumaCalifAlumno += calificaciones[i][j];

                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }

                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                }

                promedioAlum[i] = sumaCalifAlumno / calificaciones[i].Length;
                califMinAlum[i] = califMin;
                califMaxAlum[i] = califMax;
            }

            promedio = sumaCalif / totalAlumnos;

            Console.WriteLine("\nINFORMACIÓN DEL SALÓN");

            for (i = 0; i < alumnos; i++)
            {
                Console.WriteLine($"\nAlumno {i + 1}:");
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine($"  Calificación #{j + 1}: {calificaciones[i][j]}");
                }
            }

            for (i = 0; i < alumnos; i++)
            {
                Console.WriteLine($"\nINFORMACIÓN DEL ALUMNO {i + 1}");
                Console.WriteLine($"  Calificación máxima: {califMaxAlum[i]}");
                Console.WriteLine($"  Calificación mínima: {califMinAlum[i]}");
                Console.WriteLine($"  Promedio: {promedioAlum[i]}");
            }

            Console.WriteLine($"\nPromedio general: {promedio}");
        }
    }

}

