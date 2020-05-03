using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto vertice1 = new Punto(8, 2);
            Punto vertice3 = new Punto(10, 3);
            Rectangulo rectangulo1 = new Rectangulo(vertice1, vertice3);

            Console.WriteLine(Rectangulo.Mostrar(rectangulo1));
            Console.ReadKey();
        }
    }
}
