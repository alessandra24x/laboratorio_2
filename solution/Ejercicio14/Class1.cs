using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double value)
        {
            return value *= value;
        }

        public static double CalcularTriangulo(double bas, double altura)
        {
            return bas * altura / 2;
        }

        public static double CalcularCirculo(double radio)
        {
            return 3.14 * radio * radio;
        }
    }
}
