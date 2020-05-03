using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Ingrese el numero para calcular las areas: ");
            string aux = Console.ReadLine();
            if(int.TryParse(aux, out number))
            { 
                Console.WriteLine(CalculoDeArea.CalcularCuadrado(number));
                Console.WriteLine(CalculoDeArea.CalcularTriangulo(number, number));
                Console.WriteLine(CalculoDeArea.CalcularCirculo(number));
            }
            Console.ReadKey();
        }
    }
}
