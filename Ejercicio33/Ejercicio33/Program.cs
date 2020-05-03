using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro miLibro = new Libro();

            miLibro[0] = "Pepe";
            miLibro[0] = "jujuy";//si vuelvo a asignar retora el set this.paginas[i] = value;
            miLibro[1] = "Dengue";
            miLibro[4] = "lalla";
            miLibro[-1] = "Chucha";
            miLibro[5] = "jjffj";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(miLibro[i]);
            }


            Console.ReadKey();
        }
    }
}
