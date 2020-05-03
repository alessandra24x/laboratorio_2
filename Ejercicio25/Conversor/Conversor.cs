using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conversor
    {
        public static string DecimalBinario(int value)
        {
           return (Convert.ToString(value, 2));
        }

        public static int BinarioDecimal(string value)
        {
            if (Conversor.isBinary(value))
            {
                return (Convert.ToInt32(value, 2));
            }
            return -1;
        }

        public static bool isBinary(string number)
        {
            int copyOfInput = Convert.ToInt32(number);
            while (copyOfInput != 0)
            {
                if (copyOfInput % 10 > 1 || copyOfInput < 0)
                {
                    return false;
                }
                copyOfInput = copyOfInput / 10;
            }
            return true;
        }

        //public static string message(string n)
        //{
        //    if(Conversor.isBinary(n) == false)
        //    {
        //        return "Error. Ingrese un numero binario valido";
        //    }
        //    return "";
        //}
    }
}
