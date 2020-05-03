using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio11;
//Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
//siguiente firma: bool Validar(int valor, int min, int max):
//a.valor: dato a validar
//b.min y max: rango en el cual deberá estar la variable valor.
//Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
//anteriormente que esten dentro del rango -100 y 100.
//Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
//Nota: Utilizar variables escalares, NO utilizar vectores.
namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            float suma = 0;
            int min = 0;
            int max = 0;
            int i = 0;
            Console.WriteLine("Escriba 10 numeros: ");
            do
            {
                string aux = Console.ReadLine();
                if (int.TryParse(aux, out number))
                {
                    if (Validacion.Validar(number, -100, 100))
                    {
                        if (i == 0)
                        {
                            max = number;
                            min = number;
                        }
                        else if (number > max)
                        {
                            max = number;
                        }
                        else if (number < min)
                        {
                            min = number;
                        }
                        suma += number;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un numero valido (-100 / 100)");
                    }
                }
            } while (i < 10);
            double average = suma / i;
            Console.WriteLine("El numero maximo es: {0}, el minimo es: {1} y el promedio {2}", max, min, average);
            Console.ReadKey();
        }
    }
}