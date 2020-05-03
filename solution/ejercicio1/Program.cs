using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el
//valor máximo, el valor mínimo y el promedio.

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float suma = 0;
            int min = 0;
            int max = 0;
            int number;
            Console.WriteLine("Ingrese 5 numeros: ");
            for (int i = 0; i < 5; i++)
            {
                string aux = Console.ReadLine();
                if(int.TryParse(aux, out number))
                {
                    if (i == 0)
                    {
                        max = number;
                        min = number;
                    } else if (number > max)
                    {
                        max = number;
                    } else if (number < min)
                    {
                        min = number;
                    }
                    suma += number;
                }
            }

            double average = suma / 5;
            Console.WriteLine("El numero maximo es: {0}, el minimo es: {1} y el promedio {2}", max, min, average);
            Console.ReadKey();
        }
    }
}
