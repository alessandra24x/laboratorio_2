using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio16;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno al = new Alumno("Alessandra", "Fernandes", 0001);
            Alumno al2 = new Alumno("Sergio", "Tirante", 0002);
            Alumno al3 = new Alumno("Paula", "Chena", 0003);
            
            al.Estudiar(5, 8);
            al2.Estudiar(2, 6);
            al3.Estudiar(4, 5);
            al.CalcularFinal();
            al2.CalcularFinal();
            al3.CalcularFinal();
            al.Mostrar();
            al2.Mostrar();
            al3.Mostrar();
            Console.ReadKey();
        }
    }
}
