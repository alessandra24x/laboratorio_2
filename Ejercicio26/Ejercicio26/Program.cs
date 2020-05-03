using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            //void sortieren(int[] myAr)
            //{
            //    Array.Sort(myAr);
            //}
            Numeros numbers = new Numeros(20);

            numbers.CargarValores();
            Console.WriteLine(numbers.MostrarNumeros());

            Console.WriteLine(numbers.MostrarPositivos());
            Console.WriteLine(numbers.MostrarNegativos());
            //int[] myArr = new int[5] { 1, 5, 3, 8, 21 };
            //sortieren(myArr);
            //foreach (int u in myArr)
            //{
            //    if(u > 3)
            //        Console.WriteLine(u);
            //}
            Console.ReadKey();
        }
    }
}
