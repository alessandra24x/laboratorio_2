using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearFrom;
            int yearTo;
            Console.WriteLine("Ingrese el rango de años que desea saber si son bisiestos: ");
            Console.WriteLine("Desde: ");
            string aux = Console.ReadLine();
            Console.WriteLine("Hasta: ");
            string aux2 = Console.ReadLine();
            if (int.TryParse(aux, out yearFrom) && int.TryParse(aux2, out yearTo))
            {
                for(int i = yearFrom; i <= yearTo; i++)
                {
                    if(i % 4 == 0 || (i % 400 == 0 && i % 100 == 0))
                    {
                        if (i % 100 != 0)
                        {
                            Console.WriteLine("Año bisiesto: {0}", i);
                        }
                        else if (i % 400 == 0)
                        {
                            Console.WriteLine("Año bisiesto: {0}", i);

                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
