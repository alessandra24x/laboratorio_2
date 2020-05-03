using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Conversor
    {
        public static string DecimalBinario(int value)
        {
            return Convert.ToString(value, 2);
        }

        public static int BinarioDecimal(string value)
        {
            return Convert.ToInt32(value, 2);
        }
    }
}
