using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio12;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            Console.WriteLine("Ingrese numeros que se sumaran: ");
            for(int i = 0; i < 20; i++)
            {
                string aux = Console.ReadLine();
                if(int.TryParse(aux, out number))
                {
                    sum += number;
                    Console.WriteLine("¿Desea continuar? (S/N)");
                    char cont = Console.ReadLine()[0];
                    if(ValidarRespuesta.ValidaS_N(cont) == false)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Suma total: {0}", sum);
            Console.ReadKey();
        }
    }
}
