using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio19;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumame = new Sumador(0);
            //Sumador sumame2 = new Sumador(5);
            Console.WriteLine("Suma de numeros: " + sumame.Sumar(5,8));
            Console.WriteLine(sumame.Sumar("Suma de strings (concatenación): " + "ale", "ssandra"));
            Console.WriteLine("Obtiene la cantidad de sumas: " + sumame.GetCantidadSumas());

            Sumador sumameSobreCarga = new Sumador(0);
            Console.WriteLine("Suma de numeros (2do objeto): " + sumameSobreCarga.Sumar(5, 8));
            Console.WriteLine(sumameSobreCarga.Sumar("Suma de strings (concatenación): " + "ale", "enj"));
            Console.WriteLine("Obtiene la cantidad de sumas (2do objeto): " + sumameSobreCarga.GetCantidadSumas());

            int cantidadDeSumas = (int)sumame;
            int cantidadDeSuma = (int)sumameSobreCarga;

            Console.WriteLine("Conversión explicita: " + cantidadDeSumas);
            Console.WriteLine("Conversión explicita (2do objeto): " + cantidadDeSuma);

            Console.WriteLine("Sobrecarga de operador +: {0}", sumame + sumameSobreCarga);

            Console.WriteLine("Sobrecarga de operador |: {0}", sumame | sumameSobreCarga);

            Console.ReadKey();
        }
    }
}
