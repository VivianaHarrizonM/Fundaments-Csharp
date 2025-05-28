using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.seccion5
{
    internal class Referencia
    {
        static void Main(string[] args)
        {
            //Pasar por valor 
            //Variable local a main
            byte numAr = 10;

            Console.WriteLine(numAr);

            //Invocamos el método y mandamos el argumento
            Prueba(ref numAr);

            //Despues de que el método cambio su vaor, volvemos a mostrar el argumento
            Console.WriteLine(numAr);
        }
        static void Prueba(ref byte numPa)
        {
            //Modificamos el valor del parametro
            numPa = 20;
        }
    }
}

