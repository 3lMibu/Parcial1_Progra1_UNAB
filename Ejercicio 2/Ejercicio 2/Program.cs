using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal[] numerosImpares = { 3, 5, 7, 11, 24, 55, 33, 21, 45, 67 };
            decimal[] numerosPares = { 2, 4, 10, 16, 32, 64, 24, 40, 66, 88 };
            decimal[] suma = new decimal[10];
            decimal[] resta = new decimal[10];
            decimal[] multiplicacion = new decimal[10];
            decimal[] division = new decimal[10];

            //suma

            Console.WriteLine(">> La Suma de Los Arrays Es: ");

            for (int i = 0; i < numerosImpares.Length; i++)
            {
                suma[i] = numerosImpares[i] + numerosPares[i];
            }

            for (int i = 0; i < suma.Length; i++)
            {
                Console.Write("[" + suma[i] + "] ");
            }

            //resta

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(">> La Resta de Los Arrays Es: ");

            for (int i = 0; i < numerosImpares.Length; i++)
            {
                resta[i] = numerosImpares[i] - numerosPares[i];
            }

            for (int i = 0; i < resta.Length; i++)
            {
                Console.Write("[" + resta[i] + "] ");
            }

            //multiplicacion

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(">> La Multiplicacion de Los Arrays Es: ");

            for (int i = 0; i < numerosImpares.Length; i++)
            {
                multiplicacion[i] = numerosImpares[i] * numerosPares[i];
            }

            for (int i = 0; i < multiplicacion.Length; i++)
            {
                Console.Write("[" + multiplicacion[i] + "] ");
            }

            //division

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(">> La Division de Los Arrays Es: ");

            for (int i = 0; i < numerosImpares.Length; i++)
            {
                division[i] = numerosImpares[i] / numerosPares[i];
            }

            for (int i = 0; i < division.Length; i++)
            {
                Console.Write("[" + division[i].ToString("N3") +"]");
            }

        }
    }
}
