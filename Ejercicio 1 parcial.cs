using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            string dia;
            Console.WriteLine("Indica el dia y recuerda usar mayusculas al principio: ");
            dia = Console.ReadLine();
            
            switch(dia)
            {
                case "Lunes": Console.WriteLine("No es fin de semana"); break;
                case "Martes": Console.WriteLine("No es fin de semana"); break;
                case "Miercoles": Console.WriteLine("No es fin de semana"); break;
                case "Jueves": Console.WriteLine("No es fin de semana"); break;
                case "Viernes": Console.WriteLine("No es un fin de semana, pero se acerca el finde"); break;
                case "Sabado": Console.WriteLine("Es fin de semana"); break;
                case "Domingo": Console.WriteLine("Es un fin de semana, pero mañana se trabaja recuerda!"); break;
                default: Console.WriteLine("Error, no se reconoce como dia de la semana, intente de nuevo"); break;

;
            }
              
            Console.ReadKey();
        }
    }
}
