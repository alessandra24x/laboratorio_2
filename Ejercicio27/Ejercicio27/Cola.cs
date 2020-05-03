using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Cola
    {
        private static Random random;
        private Queue<int> colaNumeros;

        public Cola()
        {
            this.colaNumeros = new Queue<int>();
        }

        static Cola()
        {
            random = new Random();
        }

        public void CargarValores()
        {
            for (int i = 0; i < 20; i++)
            {
                int r = random.Next(-100, 100);
                if (r != 0)
                    colaNumeros.Enqueue(r);
                else
                    i--;
            }
        }

        public string MostrarNumeros()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int value in colaNumeros)
            {
                sb.AppendLine($"Numero: {value}");
            }
            return sb.ToString();
        }

        public string MostrarPositivos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numeros positivos ordenados:\n");
            List<int> list = colaNumeros.ToList();
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
            List<int> list = colaNumeros.ToList();
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
