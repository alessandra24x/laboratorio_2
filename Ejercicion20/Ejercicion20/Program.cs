using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro euro1 = 20d;
            Dolar dolar1 = 15d;
            Pesos pesos1 = 50d;
            Console.WriteLine(euro1.GetCantidad());
            Console.WriteLine(dolar1.GetCantidad());
            Console.WriteLine(pesos1.GetCantidad());

            Euro e = new Euro(10);
            Dolar d = new Dolar(10);
            Pesos p = new Pesos(10);

            d = (Dolar)e;
            Console.WriteLine(d.GetCantidad());

            Euro aux_e = e + d;
            Console.WriteLine("Euro + Dólar: {0}", aux_e.GetCantidad());
            aux_e = e + p;
            Console.WriteLine("Euro + Pesos: {0}", aux_e.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Dolar aux_d = d + e;
            Console.WriteLine("Dólar + Euro: {0}", aux_d.GetCantidad());
            aux_d = d + p;
            Console.WriteLine("Dólar + Pesos: {0}", aux_d.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Pesos aux_p = p + e;
            Console.WriteLine("Pesos + Euro: {0}", aux_p.GetCantidad());
            aux_p = p + d;
            Console.WriteLine("Pesos + Dólar {0}", aux_p.GetCantidad());

            Console.ReadKey();
        }
    }
}
