using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio13;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 8;
            Console.WriteLine("Valor inicial: {0}", number);
            var binary = Conversor.DecimalBinario(number);
            Console.WriteLine("Binario: {0}", binary);
            var integer = Conversor.BinarioDecimal(binary);
            Console.WriteLine("Decimal: {0}", integer);
            Console.Write("Decimal 17 a Binario: {0}\n", Binary.decToBinary(17));
            Console.Write("Binario 1001 a decimal: {0}", Binary.binaryToDec("1001"));
            Console.ReadKey();
        }
    }
}
