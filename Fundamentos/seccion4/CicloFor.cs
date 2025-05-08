using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.seccion4
{
    internal class CicloFor
    {
        static void Main(string[] args)
        {
            double calif1, calif2, calif3, promedio;

            Console.WriteLine("Dame tu primer calificación");
            calif1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame tu segunda calificación");
            calif2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame tu tercer calificación");
            calif3 = Convert.ToDouble(Console.ReadLine());

            promedio = (calif1 + calif2 + calif3) / 3;

            Console.WriteLine("El promedio es: {0}", promedio);
        }
    }
}
