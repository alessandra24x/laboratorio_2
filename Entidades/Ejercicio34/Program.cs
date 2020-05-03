using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto l1 = new Moto(2, 0, VehiculoTerrestre.Colores.Rojo, 250);
            Automovil l2 = new Automovil(4, 2, 4, 4, VehiculoTerrestre.Colores.Azul);
            Camion l3 = new Camion(8, 2, VehiculoTerrestre.Colores.Negro, 6, 7000);
            Console.WriteLine(l1.Mostrar());
            Console.WriteLine(l2.Mostrar());
            Console.WriteLine(l3.Mostrar());
            Console.ReadKey();
        }
    }
}
