using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio negocio1 = new Negocio("majura");
            Cliente josefa = new Cliente(1, "josefa");
            Cliente martin = new Cliente(8, "martin");
            Cliente alex = new Cliente(2, "alex");
            Cliente a2 = new Cliente(25, "alex");

            //negocio1.Cliente = josefa;
            //negocio1.Cliente = martin;
            //negocio1.Cliente = alex;
            //negocio1.Cliente = a2;

            if (negocio1 + josefa)
            {
                Console.WriteLine("Agregado");
            }
            if (negocio1 + alex)
            {
                Console.WriteLine("Agregado");
            }
            if (negocio1 + martin)
            {
                Console.WriteLine("Agregado");
            }

            for (int i = 0; i < negocio1.ClientesPendientes;)
            {
            Console.WriteLine("Clientes en espera: {0}\n\n", negocio1.ClientesPendientes);

            Console.WriteLine("Atendiendo cliente...\n\n");
            if (~negocio1)
            {
                Console.WriteLine("Atendido con éxito\n\n");
            }
            else
            {
                Console.WriteLine("No se pudo atender\n\n");
            }

            Console.WriteLine("<--------------------------------------------------------->\n\n");
            }

            Console.WriteLine("FIN");

            Console.ReadKey();
        }
    }
}
