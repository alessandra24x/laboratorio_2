using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class Calculadora
    {
        public static double Calcular(int number, int number2, char c)
        {
            if(c.Equals('+'))
            {
                return number + number2;
            }
            if (c.Equals('-'))
            {
                return number - number2;
            }
            if (c.Equals('*'))
            {
                return number * number2;
            }
            if (c.Equals('/'))
            {
                return number / number2;
            }
            return 0;
        }
        
        public static bool Validar(int number)
        {
            if(number != 0)
            {
                return true;
            }
            return false;
        }

    }
}
