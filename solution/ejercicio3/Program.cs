using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
//por consola.
//Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Ingrese un numero: ");
            string aux = Console.ReadLine();
            if (int.TryParse(aux, out number))
            {
                for (int i = 2; i <= number; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime)
                    {
                        Console.WriteLine("Number: {0}", i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
