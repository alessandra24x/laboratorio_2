using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Probando;

namespace Probando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("La suma de 2+4 es ");
            Console.WriteLine(Operacion.Sumar(2, 4));
            Console.Write("La resta de 6-2 es ");
            Console.WriteLine(Operacion.Restar(6, 2));
            Console.ReadKey();
        }
    }
}
