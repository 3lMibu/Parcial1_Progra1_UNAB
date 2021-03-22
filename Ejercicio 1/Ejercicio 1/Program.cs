using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario1;
            string usuario2;

            decimal[] artiUsuario1 = new decimal[4];
            decimal[] artiUsuario2 = new decimal[4];

            decimal iva = 0.13M;
            decimal descuento = 0;
            decimal ivaTotal = 0;
            decimal compraTotal = 0;

            //user 1

            Console.WriteLine("Ingrese la cantidad de articulos comprados por el usuario 1");
            int cantidad = int.Parse(Console.ReadLine());


            if (cantidad < 5)
            {
                artiUsuario1 = new decimal[cantidad];

                Console.WriteLine("Escribe Nombre de Usuario: ");
                usuario1 = (Console.ReadLine());

                decimal total = 0;

                for (int i = 0; i < artiUsuario1.Length; i++)
                {
                    Console.WriteLine("Escriba el precio del artículo # {0}", i + 1);
                    artiUsuario1[i] = decimal.Parse(Console.ReadLine());

                    total = artiUsuario1[i] + total;
                }
                Console.WriteLine("\nResumen Precios de Articulos:");
                for (int i = 0; i < artiUsuario1.Length; i++)
                {
                    Console.WriteLine("$ {0}", artiUsuario1[i]);

                }

                if (total >= 145 && total < 250)
                {

                    ivaTotal = total * iva;

                    descuento = (total + ivaTotal) * 0.06M;

                    compraTotal = (total + ivaTotal) - descuento;
                }
                if (total < 145)
                {
                    ivaTotal = total * iva;
                    compraTotal = (total + ivaTotal);
                }
                if (total >= 250)
                {
                    ivaTotal = total * iva;

                    descuento = (total + ivaTotal) * 0.08M;

                    compraTotal = (total + ivaTotal) - descuento;
                }

                Console.WriteLine("<<<<< Detalle de Compra Usuario 1 >>>>>");
                Console.WriteLine("");
                Console.WriteLine("Usuario: {0}", usuario1);
                Console.WriteLine("Subtotal: {0}", total);
                Console.WriteLine("IVA: {0}", ivaTotal);
                Console.WriteLine("Descuento Total: {0}", descuento);
                Console.WriteLine("");
                Console.WriteLine("Compra Total: ${0:N2}", compraTotal);

            }
            else
            {
                Console.WriteLine("<< Por favor no exceder de 4 Articulos por persona. Vuelva a intentarlo >>");
            }

            //user 2

            Console.WriteLine("\nIngrese la cantidad de articulos comprados por el usuario 2");
            cantidad = int.Parse(Console.ReadLine());


            if (cantidad < 5)
            {
                artiUsuario2 = new decimal[cantidad];

                Console.WriteLine("Escribe Nombre de Usuario: ");
                usuario2 = (Console.ReadLine());

                decimal total = 0;

                for (int i = 0; i < artiUsuario1.Length; i++)
                {
                    Console.WriteLine("Escriba el precio del art: {0}", i + 1);
                    artiUsuario2[i] = decimal.Parse(Console.ReadLine());

                    total = artiUsuario2[i] + total;
                }
                Console.WriteLine("\nResumen Precios: \n");
                for (int i = 0; i < artiUsuario2.Length; i++)
                {
                    Console.WriteLine("$ {0}", artiUsuario2[i]);

                }

                if (total >= 145 && total < 250)
                {

                    ivaTotal = total * iva;

                    descuento = (total + ivaTotal) * 0.06M;

                    compraTotal = (total + ivaTotal) - descuento;
                }
                if (total < 145)
                {
                    ivaTotal = total * iva;
                    compraTotal = (total + ivaTotal);
                }
                if (total >= 250)
                {
                    ivaTotal = total * iva;

                    descuento = (total + ivaTotal) * 0.08M;

                    compraTotal = (total + ivaTotal) - descuento;
                }

                Console.WriteLine("<<<<< Detalle de Compra Usuario 2 >>>>>");
                Console.WriteLine("");
                Console.WriteLine("Usuario: {0}", usuario2);
                Console.WriteLine("Subtotal: {0}", total);
                Console.WriteLine("IVA: {0}", ivaTotal);
                Console.WriteLine("Descuento Total: {0}", descuento);
                Console.WriteLine("");
                Console.WriteLine("Compra Total: ${0:N2}", compraTotal);

            }
            else
            {
                Console.WriteLine("<< Por favor no exceder de 4 Articulos por persona. Vuelva a intentarlo >>");
            }

        }
    }
}
