using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio15;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingrese el primer numero: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la operación que desea realizar (+ - / *)");
                char c = Console.ReadLine()[0];

                switch (c)
                {
                    case '+':
                        Console.WriteLine(Calculadora.Calcular(number, number2, c));
                        break;
                    case '-':
                        Console.WriteLine(Calculadora.Calcular(number, number2, c));
                        break;
                    case '/':
                        if (Calculadora.Validar(number2))
                        {
                            Console.WriteLine(Calculadora.Calcular(number, number2, c));
                        }
                        else
                            Console.WriteLine("No se puede dividir entre cero");
                        break;
                    case '*':
                        Console.WriteLine(Calculadora.Calcular(number, number2, c));
                        break;
                    case 'S':
                        break;
                    default:
                        break;

                }
                Console.WriteLine("Si desea continuar ingrese cualquier tecla, si desea salir ingrese la tecla S");
            } while (!'S'.Equals(Console.ReadLine()[0]));
            Console.ReadKey();
        }
    }
}
