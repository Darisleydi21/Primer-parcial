using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Coloque 1 si pagara con tarjeta, y 2 si pagara en efectivo: ");
            int tipo = Convert.ToInt32(Console.ReadLine());

            if (tipo == 2)
            {
                Console.WriteLine("Su pago ha sido realizado");

            }
            else
                Console.WriteLine("Inserte numero de tarjeta: ");
            int tarjeta = Convert.ToInt32(Console.ReadLine());

            int dig = tarjeta.ToString().Length;

            if (dig == 12)
            {
                Console.WriteLine("Su pago se ha realizado con exito: " + precio);

            }
            else
                Console.WriteLine("Error, la cantidad de digitos debe ser 12");

            Console.ReadKey();
            
        }
    }
}
