using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 1 / 1.16f;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static implicit operator Euro(double cantidad)
        {
            Euro euro = new Euro(cantidad);
            return euro;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            Dolar d = (Dolar)e;
            Pesos p = (Pesos)d;
            return p;
            //return (Pesos)((Dolar)e);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return e == (Euro)p;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e, Euro e2)
        {
            return e.cantidad == e2.cantidad;
        }

        public static bool operator !=(Euro e, Euro e2)
        {
            return !(e == e2);
        }
    }
}
