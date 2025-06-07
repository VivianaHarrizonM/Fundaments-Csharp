using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.seccion6
{
    internal class CalificacionesBiDi
    {
       /* static void Main(string[] args)
        {
            byte i, j, numCal, alumnos;
            double sumaCalif = 0, promedio, califMin = 10, califMax = 0;

            Console.Write("Ingresa el número de calificaciones por alumno: ");
            numCal = Convert.ToByte(Console.ReadLine());

            Console.Write("Ingresa el número de alumnos: ");
            alumnos = Convert.ToByte(Console.ReadLine());

            double[,] calificaciones = new double[alumnos, numCal];

            // Ingreso de calificaciones
            for (i = 0; i < alumnos; i++)
            {
                Console.WriteLine($"\nAlumno {i + 1}:");
                for (j = 0; j < numCal; j++)
                {
                    Console.Write($"  Ingresa la calificación #{j + 1}: ");
                    double calif = Convert.ToDouble(Console.ReadLine());

                    calificaciones[i, j] = calif;
                    sumaCalif += calif;

                    if (calif < califMin) califMin = calif;
                    if (calif > califMax) califMax = calif;
                }
            }

            promedio = sumaCalif / (alumnos * numCal);

            // Resultados
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Promedio general: {promedio:F2}");
            Console.WriteLine($"Calificación máxima: {califMax}");
            Console.WriteLine($"Calificación mínima: {califMin}");
        }
       */
    }
}
