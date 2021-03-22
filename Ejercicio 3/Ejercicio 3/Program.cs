using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, año;
            int diaSiguiente, mesSiguiente, añoSiguiente;

            Console.WriteLine("<<< Ingrese una fecha en formato dd/mm/aa >>>");
            Console.WriteLine("");
            Console.Write("Ingrese el dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el año: ");
            año = int.Parse(Console.ReadLine());
            Console.Write("");
            Console.WriteLine("La fecha actual ingresada es: {0}/{1}/{2}", dia, mes, año); 

            if ((dia == 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia == 29 && mes == 2) || (dia == 28 && mes == 2 && ((año % 4 != 0) || (año % 100) == 0) && (año % 400) != 0) || dia == 31)
            {
                mesSiguiente = mes + 1;
                diaSiguiente = 1;
            }
            else
            {
                diaSiguiente = dia + 1;
                mesSiguiente = mes;
            }

            if (diaSiguiente == 1 && mesSiguiente == 13)
            {
                mesSiguiente = 1;
                añoSiguiente = año + 1;
            }
            else
                añoSiguiente = año;
            Console.WriteLine("");
            Console.WriteLine(">> La fecha del día siguiente es: {0}/{1}/{2}",diaSiguiente,mesSiguiente,añoSiguiente);


        }
    }
}
