using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    public class Numeros
    {
        private static Random random;
        private int[] num;

        public Numeros(int capacidad)
        {
            this.num = new int[capacidad];
        }

        static Numeros()
        {
            random = new Random();
        }

        public void CargarValores()
        {
            for (int i = 0; i < num.Length; i++)
            {
                int r = random.Next(-100, 100);
                if (r != 0)
                    this.num[i] = r;
                else
                    i--;
            }

        }

        public string MostrarNumeros()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < num.Length; i++)
            {
                sb.AppendLine($"Numero {i + 1}: {num[i]}");
            }
            return sb.ToString();
        }

        public string MostrarPositivos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numeros positivos ordenados:\n");
            //Array.Sort(num);
            //Array.Reverse(num);
            //Array.Sort<int>(num, new Comparison<int>(
            //      (i1, i2) => i2.CompareTo(i1)));
            Array.Sort<int>(num, delegate (int m, int n)
            { return n - m; });
            foreach (int value in num)
            {
                if (value > 0)
                {
                    sb.AppendLine($"Numero: {value}");
                }
            }
            return sb.ToString();
        }

        public string MostrarNegativos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numeros negativos ordenados:\n");
            Array.Sort(num);
            foreach (int value in num)
            {
                if (value < 0)
                {
                    sb.AppendLine($"Numero: {value}");
                }
            }
            return sb.ToString();
        }
    }
}
