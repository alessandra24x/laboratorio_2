using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo eq = new Equipo(5, "AS Roma");
            Jugador jug = new Jugador(28452032, "Lucio Figueroa");
            Jugador jug2 = new Jugador(28523120, "Sergio Florenzi");
            Jugador jug3 = new Jugador(24587320, "Daniele DeRossi", 10, 15);
            Jugador jug4 = new Jugador(25896321, "Miralem Pjanic", 40, 58);
            Jugador jug5 = new Jugador(30123589, "Edin Dzeko", 85, 70);
            Jugador jug6 = new Jugador(29587452, "Francesco Totti", 655, 470);

            //if (eq + jug)
            //    Console.WriteLine("Agregado");
            //else
            //    Console.WriteLine("no agregado");

            //if (eq + jug2)
            //    Console.WriteLine("Agregado");
            //else
            //    Console.WriteLine("no agregado");

            if (eq + jug3)
                Console.WriteLine("Agregado");
            else
                Console.WriteLine("no agregado");

            if (eq + jug4)
                Console.WriteLine("Agregado");
            else
                Console.WriteLine("no agregado");

            if (eq + jug5)
                Console.WriteLine("Agregado");
            else
                Console.WriteLine("no agregado");

            if (eq + jug4)
                Console.WriteLine("Agregado");
            else
                Console.WriteLine("no agregado");

            if (eq + jug6)
                Console.WriteLine("Agregado");
            else
                Console.WriteLine("no agregado");

            Console.WriteLine("\n//////////////////////////////////////////\n");

            Console.WriteLine(eq.MostrarDatosEquipo());

            Console.ReadKey();
        }
    }
}
