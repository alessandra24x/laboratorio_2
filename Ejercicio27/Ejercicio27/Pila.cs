using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Pila
    {
        private static Random random;
        private Stack<int> pilaNumeros;

        public Pila()
        {
            this.pilaNumeros = new Stack<int>();
        }

        static Pila()
        {
            random = new Random();
        }

        public void CargarValores()
        {
            for (int i = 0; i < 20; i++)
            {
                int r = random.Next(-100, 100);
                if (r != 0)
                    pilaNumeros.Push(r);
                else
                    i--;
            }
        }

        public string MostrarNumeros()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int value in pilaNumeros)
            {
                sb.AppendLine($"Numero: {value}");
            }
            return sb.ToString();
        }

        public string MostrarPositivos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numeros positivos ordenados:\n");
            List<int> list = pilaNumeros.ToList();
            list.Sort(Lista.Ordenar);

            foreach (int value in list)
            {
                if (value > 0)
                    sb.AppendLine($"Numero: {value}");
            }
            return sb.ToString();
        }

        public string MostrarNegativos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numeros negativos ordenados:\n");
            List<int> list = pilaNumeros.ToList();
            list.Sort();

            foreach (int value in list)
            {
                if (value < 0)
                    sb.AppendLine($"Numero: {value}");
            }
            return sb.ToString();
        }
    }
}
