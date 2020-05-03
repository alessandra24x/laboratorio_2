using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia roma = new Competencia(3, 5);
            AutoF1 auto1 = new AutoF1(1, "bmw");
            AutoF1 auto2 = new AutoF1(2, "renault");
            AutoF1 auto3 = new AutoF1(3, "mercedes");
            AutoF1 auto4 = new AutoF1(4, "ferrari");
            AutoF1 auto5 = new AutoF1(4, "ferrari");

            if (roma + auto1)
                Console.WriteLine("Agregado correctamente");
            else
                Console.WriteLine("No agregado");

            if (roma + auto2)
                Console.WriteLine("Agregado correctamente");
            else
                Console.WriteLine("No agregado");
            if (roma + auto3)
                Console.WriteLine("Agregado correctamente");
            else
                Console.WriteLine("No agregado");

            if (roma + auto4)
                Console.WriteLine("Agregado correctamente");
            else
                Console.WriteLine("No agregado");

            if (auto4 == auto5)
                Console.WriteLine("Autos iguales");

            if (roma - auto1)
                Console.WriteLine("Desagregado");

            Console.WriteLine(roma.MostrarDatos());
            Console.ReadKey();
        }
    }
}
