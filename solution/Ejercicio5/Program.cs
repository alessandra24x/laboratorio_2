using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberEnd;
            int number = 1;
            int sumA = 0;
            int sumB = 0;

            Console.WriteLine("Ingrese el numero hasta donde quiera que busquemos centro numerico: ");
            string aux = Console.ReadLine();
            if (int.TryParse(aux, out numberEnd)) {
                do
                {
                    for(int i = 1; i < number; i++)
                    {
                        sumA += i;
                    }
                    for(int j = number +1; j < number *2; j++)
                    {
                        if (sumA == sumB)
                        {
                            Console.WriteLine("AMAZING!!! YOU HAVE FOUND A NUMBER CENTER: {0}", number);
                            break;
                        } else
                        {
                            sumB += j;
                        }

                    }
                    number++;
                    sumA = 0;
                    sumB = 0;
                } while (number < numberEnd);
                Console.ReadKey();
            }
        }
    }
}
