
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.seccion2
{
    internal class seccion2
    {

        /*static void Main(string[] args)
        {
            
            int a = 30, b = 20;
            Console.WriteLine(a == b);
            Console.WriteLine(b != a);
            Console.WriteLine(6 == 6);
            Console.WriteLine(a < b);
            Console.WriteLine(b > a);
            Console.WriteLine(a >= b);
            Console.WriteLine(b <= a);
            

            //Condicionales
            int numero;

            Console.WriteLine("****** Condicionales *******");

            //Pedir un numero al usuario y revisar si es positivo o negativo
            Console.WriteLine("----- Determinar si el número es positivo o negativo -----");
            Console.Write("Dame un número: " );
            numero= Convert.ToInt32(Console.ReadLine());

            //Usamos la condicional menor que cero para saber si es positivo
            if (numero > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }

            Console.WriteLine("--------Division de dos numeros-------");
            //***********Programa que hace la division de dos numeros ************

            //Variables
            double dividendo, divisior, resultado;

            Console.Write("Dame el dividendo: ");
            dividendo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame el divisor: ");
            divisior = Convert.ToDouble(Console.ReadLine());

            if (divisior != 0)
            {
                resultado = dividendo / divisior;
                Console.WriteLine("{0} / {1} = {2}", dividendo, divisior, resultado);
            }
            else
            {
                Console.WriteLine("El divisor debe ser mayor que cero ");
            }

            // ***** Programa que dertermina si eres mayir de edad, con base a tu edad.**********
            //Variables
            byte edad;

            Console.Write("¿Que edad tienes?: ");
            edad= Convert.ToByte(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad: {0}", edad);
            }
            else
            {
                Console.WriteLine("Eres menor de edad: {0}", edad);
            }
            

            // ********** Se necesita un programa que realice las 4 operaciones básicas: suma, resta, multiplicación y división, a partir de dos numeros, la operación deseada será elejifa por el usuario.

            //variables
            decimal num1, num2, resultado;
            byte opcion;

            //Mostramos el menú
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            Console.Write("Elige una opción: ");
            opcion = Convert.ToByte(Console.ReadLine());

            //Pedimos los números
            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            if (opcion == 1)
            {
                resultado = num1 + num2;
                Console.WriteLine("El resultado de la suma es:  {0}", resultado);
            }
            else if (opcion == 2)
                {
                 resultado = num1 - num2;
                 Console.WriteLine("El resultado de la resta es:  {0}", resultado);
                }
             else if (opcion == 3)
                {
                 resultado = num1 * num2;
                 Console.WriteLine("El resultado de la multiplicación es:  {0}", resultado);
                }
             else if (opcion == 4)
                {
                    if (num2 != 0)
                       {
                         resultado = num1 / num2;
                         Console.WriteLine("El resultado de la división es: {0}", resultado);
                       }
                     else
                       {
                         Console.WriteLine("No es posible dividir entre cero");
                       }

             }*/

        // /--------/TABLAS DE VERDAD /------------/
        /* //Negación Lógica
        bool bateria;
        Console.Write("¿Hay bateria? (true/false)");
        bateria= Convert.ToBoolean(Console.ReadLine());

        if (!(bateria == true))
        {
            Console.WriteLine("Conecta el celular");

        }
        else
        {
            Console.WriteLine("No es necesario conectar el celular");
        }*/

        /*
        byte edad;
        bool licencia;

        bool p, q;
        p = false;
        q = false;
        float calPrepa, calExamen;

        ///--------- || ----------///
        Console.WriteLine("------- Operador || --------");
        Console.WriteLine(p || q);
        Console.Write("¿Con qué promedio concluiste tus estudios de preparatoria? ");
        calPrepa = Convert.ToSingle(Console.ReadLine());

        Console.Write("¿Que calificación obtuviste en tu examen de ingreso? ");
        calExamen = Convert.ToSingle(Console.ReadLine());

        if ((calPrepa >= 9) || (calExamen >= 9.5))
        {
            Console.WriteLine("¡ Felicidades tienes la beca !");
        }
        else
        {
            Console.WriteLine(" ¡ Lo siento, no eres acreedor para una beca !");
        }

        ///----- && -----////
        Console.WriteLine("------- Operador && --------");
        Console.Write("¿Que edad tienes?: ");
        edad = Convert.ToByte(Console.ReadLine());

        Console.Write("¿Tienes licencia de conducir? ");
        licencia = Convert.ToBoolean(Console.ReadLine());

        if (edad >= 18 && licencia == true)
        {
            Console.WriteLine("Puedes condicir");
        }
        else
        {
            Console.WriteLine("Lo siento no puedes conducir");
        }*/

        //// --------------Ejecicio ------------------------
        /*
                    float energia;
                    bool propulsorIzquierdo, propulsorDerecho;

                    Console.Write("Ingrese el nivel de energia: ");
                    energia = Convert.ToSingle(Console.ReadLine());

                    Console.Write("¿El propulsor izquierdo esta en buen estado (true/false)? ");
                    propulsorIzquierdo = Convert.ToBoolean(Console.ReadLine());

                    Console.Write("¿El propulsor derecho esta en buen estado (true/false)? ");
                    propulsorDerecho = Convert.ToBoolean(Console.ReadLine());

                    if ((((propulsorIzquierdo && (propulsorDerecho)) == true) && (energia >= 75)) || ((((propulsorIzquierdo) || (propulsorDerecho)) == true) && (energia == 100)))
                    {
                        Console.WriteLine("Puedes despegar");
                    }
                    else 
                    {
                        Console.WriteLine("Lo siento no es seguro despegar");
                    }
                }
        */
    }
}
