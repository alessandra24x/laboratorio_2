using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Binary
    {
       
        public static string decToBinary(int n)
        {
            int i = 0;
            int r = 0;
            StringBuilder sb = new StringBuilder();
            StringBuilder bin = new StringBuilder();
            while(n > 0)
            {
                r = n % 2;
                n = n / 2;
                sb.Append(r);
                i++;
            }
            for(int j = i - 1; j >= 0; j--)
            {
                bin.Append(sb[j]);
            }
            return bin.ToString();
        }

        public static int binaryToDec(string n)
        {
            int binaryNumber = int.Parse(n);
            int decimalValue = 0;
            int base1 = 1;

            while(binaryNumber > 0)
            {
                int rem = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += rem * base1;
                base1 = base1 * 2;
            }
            return decimalValue;
        }
    }
}
