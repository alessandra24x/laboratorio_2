using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius c = new Celsius(30);
            Fahrenheit f = new Fahrenheit(85);
            Kelvin k = new Kelvin(274);

            Celsius nuevoC = 32;
            Fahrenheit nuevoF = 96;
            Kelvin nuevoK = 55;

            Console.WriteLine("CONVERSION IMPLICITA: Celsius: {0} Fahrenheit: {1} Kelvin: {2}\n", nuevoC.GetCantidad(), nuevoF.GetCantidad(), nuevoK.GetCantidad());

            Kelvin nuevoKExp = (Kelvin)f;
            Fahrenheit nuevoFExp = (Fahrenheit)k;
            Celsius nuevoCExp = (Celsius)f;
            Kelvin nuevoK2Exp = (Kelvin)c;
            Fahrenheit nuevoF2Exp = (Fahrenheit)c;
            Celsius nuevoC2Exp = (Celsius)k;

            Console.WriteLine("CONVERSION EXPLICITA: \n");
            Console.WriteLine($"{c.GetCantidad()} grados Fahrenheit a Kelvin: {nuevoKExp.GetCantidad().ToString("0.##")}\n");
            Console.WriteLine($"{f.GetCantidad()} grados Fahrenheit a Celsius: {nuevoCExp.GetCantidad().ToString("0.##")}\n");
            Console.WriteLine($"{c.GetCantidad()} grados Celsius a Kelvin: {nuevoK2Exp.GetCantidad().ToString("0.##")}\n");
            Console.WriteLine($"{c.GetCantidad()} grados Celsius a Fahrenheit: {nuevoF2Exp.GetCantidad().ToString("0.##")}\n");
            Console.WriteLine($"{k.GetCantidad()} grados Kelvin a Fahrenheit: {nuevoFExp.GetCantidad().ToString("0.##")}\n");
            Console.WriteLine($"{k.GetCantidad()} grados Kelvin a Celsius: {nuevoC2Exp.GetCantidad().ToString("0.##")}\n");

            Console.WriteLine("----------------------------------------------");

            Fahrenheit aux_f = f + c;
            Console.WriteLine("Fahrenheit + Celsius: {0}", aux_f.GetCantidad().ToString("0.##"));
            aux_f = f + k;
            Console.WriteLine("Fahrenheit + Kelvin: {0}", aux_f.GetCantidad().ToString("0.##"));
            Console.WriteLine("----------------------------------------------");

            Celsius aux_c = c + f;
            Console.WriteLine("Celsius + Fahrenheit: {0}", aux_c.GetCantidad().ToString("0.##"));
            aux_c = c + k;
            Console.WriteLine("Celsius + Kelvin: {0}", aux_c.GetCantidad().ToString("0.##"));
            Console.WriteLine("----------------------------------------------");

            Kelvin aux_k = k + c;
            Console.WriteLine("Kelvin + Celsius: {0}", aux_k.GetCantidad().ToString("0.##"));
            aux_k = k + f;
            Console.WriteLine("Kelvin + Fahrenheit: {0}", aux_k.GetCantidad().ToString("0.##"));

            Console.WriteLine("----------------------------------------------");

            aux_f = f - c;
            Console.WriteLine("Fahrenheit - Celsius: {0}", aux_f.GetCantidad().ToString("0.##"));
            aux_f = f - k;
            Console.WriteLine("Fahrenheit - Kelvin: {0}", aux_f.GetCantidad().ToString("0.##"));
            Console.WriteLine("----------------------------------------------");

            aux_c = c - f;
            Console.WriteLine("Celsius - Fahrenheit: {0}", aux_c.GetCantidad().ToString("0.##"));
            aux_c = c - k;
            Console.WriteLine("Celsius - Kelvin: {0}", aux_c.GetCantidad().ToString("0.##"));
            Console.WriteLine("----------------------------------------------");

            aux_k = k - c;
            Console.WriteLine("Kelvin - Celsius: {0}", aux_k.GetCantidad().ToString("0.##"));
            aux_k = k - f;
            Console.WriteLine("Kelvin - Fahrenheit: {0}", aux_k.GetCantidad().ToString("0.##"));

            Console.ReadKey();

        }
    }
}
