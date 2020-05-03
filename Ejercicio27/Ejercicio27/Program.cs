using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("///////////////LISTAS///////////////\n");
            Lista listaN = new Lista();
            listaN.CargarValores();
            Console.WriteLine(listaN.MostrarNumeros());
            Console.WriteLine(listaN.MostrarPositivos());
            Console.WriteLine(listaN.MostrarNegativos());

            Console.WriteLine("///////////////COLAS///////////////\n");
            Cola colaN = new Cola();
            colaN.CargarValores();
            Console.WriteLine(colaN.MostrarNumeros());
            Console.WriteLine(colaN.MostrarPositivos());
            Console.WriteLine(colaN.MostrarNegativos());

            Console.WriteLine("///////////////PILAS///////////////\n");
            Pila pilaN = new Pila();
            pilaN.CargarValores();
            Console.WriteLine(colaN.MostrarNumeros());
            Console.WriteLine(pilaN.MostrarPositivos());
            Console.WriteLine(pilaN.MostrarNegativos());

            Console.ReadKey();
        }
    }
}
