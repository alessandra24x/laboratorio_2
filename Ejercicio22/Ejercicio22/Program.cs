using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////CONVERSION IMPLICITA////////////////////
            NumeroDecimal nD = 8;
            NumeroBinario nB = "1000";
            //NumeroBinario num = "12";
            //Console.WriteLine(nB.GetNumero());


            ///////SUMA Y RESTA DE OPERADORES/////////////////
            NumeroBinario bin = nB + nD;
            NumeroBinario b = nB - nD;
            Console.WriteLine(b.GetNumero());
            Console.WriteLine(bin.GetNumero());

            NumeroDecimal sumDec = nD + nB;
            NumeroDecimal resDec = nD - nB;
            Console.WriteLine(sumDec.GetNumero());
            Console.WriteLine(resDec.GetNumero());


            ////////OPERADOR IGUAL Y DISTINTO/////////////////
            if (nB == nD)
            {
                Console.WriteLine("Son iguales");
            } else
            {
                Console.WriteLine("Son distintos");
            }

            ////////CONVERSION EXPLICITA////////////////
            NumeroDecimal numD = (NumeroDecimal) (NumeroBinario) "100011";
            nD = (NumeroDecimal) nB;
            Console.WriteLine(numD.GetNumero());

            NumeroBinario numB = (NumeroBinario)(NumeroDecimal)85;
            nB = (NumeroBinario)nD;
            Console.WriteLine(numB.GetNumero());


            Console.ReadKey();

        }
    }
}
