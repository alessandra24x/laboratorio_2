using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        private static Random random;

        public Alumno (string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        
        static Alumno()
        {
            random = new Random();
        }

        public void CalcularFinal()
        {
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = random.Next(1, 10);
            } else
            {
                this.notaFinal = -1;
            }
        
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0} Apellido: {1} Nota1: {2} Nota2: {3} Legajo: {4}", this.nombre, this.apellido, this.nota1, this.nota2, this.legajo);
            if (this.notaFinal != -1)
            {
                Console.WriteLine("Nota final: {0}", this.notaFinal);
            }
            else
            {
                Console.WriteLine("Alumno Desaprobado");
            }
        }
    }

}
