using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Lista

    {
        private static Random random;
        private List<int> listaNumeros;

        public Lista()
        {
            this.listaNumeros = new List<int>();
        }

        static Lista()
        {
            random = new Random();
        }

        public void CargarValores()
        {
            for (int i = 0; i < 20; i++)
            {
                int r = random.Next(-100, 100);
                if (r != 0)
                    listaNumeros.Add(r);
                else
                    i--;
            }
        }

        public static int Ordenar(int num1, int num2)
        {
            if (num1 > num2)
                return -1;
            else if (num1 < num2)
                return 1;
            else
                return 0;
        }

        public string MostrarNumeros()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                sb.AppendLine($"Numero {i + 1}: {listaNumeros[i]}");
            }
            return sb.ToString();
        }

        public string MostrarPositivos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numeros positivos ordenados:\n");
            listaNumeros.Sort(Lista.Ordenar);
            
            foreach (int value in listaNumeros)
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
            listaNumeros.Sort();

            foreach (int value in listaNumeros)
            {
                if (value < 0)
                    sb.AppendLine($"Numero: {value}");
            }
            return sb.ToString();
        }
    }
}