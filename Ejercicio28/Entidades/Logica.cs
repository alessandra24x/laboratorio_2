using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class Logica
    {

        public static void Contador(string richText)
        {
            Dictionary<string, int> palabras = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();
            //string[] palabraArray = richText.Split(' ');

            foreach (string p in richText.Split(' '))
            {
                if (!palabras.ContainsKey(p))
                    palabras.Add(p, 1);
                else
                    palabras[p]++;
            }

            List<KeyValuePair<string, int>> lista = palabras.ToList();
            lista.Sort(Logica.Ordenar);
            int contador = 0;

            foreach (KeyValuePair<string, int> item in lista)
            {
                if (contador < 3)
                {
                    sb.AppendLine($"{item.Key}" + " " + $"{item.Value}");
                    contador++;
                }
            }

            MessageBox.Show(sb.ToString());
        }

        public static int Ordenar(KeyValuePair<string, int> palabra1, KeyValuePair<string, int> palabra2)
        {
            return palabra2.Value.CompareTo(palabra1.Value);
        }

    }
}


