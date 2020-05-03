using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ingresar un número y mostrar: el cuadrado y el cubo del mismo.Se debe validar que el número sea
//mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
//Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            while (true) { 
                Console.WriteLine("Ingrese un numero: ");
                string aux = Console.ReadLine();
                if (int.TryParse(aux, out number))
                {
                    if(number > 0)
                    {
                        double cuadrado = Math.Pow(number, 2);
                        double cubo = Math.Pow(number, 3);
                        Console.WriteLine("El cuadrado del numero: {0} es {1}", number, cuadrado);
                        Console.WriteLine("El cubo del numero: {0} es {1}", number, cubo);
                        Console.ReadKey();
                        break;
                    } else
                    {
                        Console.WriteLine("ERROR. ¡Reingresar número!");
                        
                    }
                }
            }
        }
    }
}


////Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el
////valor máximo, el valor mínimo y el promedio.

//namespace ejercicio1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            float suma = 0;
//            int min = 0;
//            int max = 0;
//            int number;
//            Console.WriteLine("Ingrese 5 numeros: ");
//            for (int i = 0; i < 5; i++)
//            {
//                string aux = (Console.ReadLine());
//                if (int.TryParse(aux, out number))
//                {
//                    if (i == 0)
//                    {
//                        max = number;
//                        min = number;
//                    }
//                    else if (number > max)
//                    {
//                        max = number;
//                    }
//                    else if (number < min)
//                    {
//                        min = number;
//                    }
//                    suma += number;
//                }
//            }

//            double average = suma / 5;
//            Console.WriteLine("El numero maximo es: {0}, el minimo es: {1} y el promedio {2}", max, min, average);
//            Console.ReadKey();
//        }
//    }
//}

