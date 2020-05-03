using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1.00;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public static implicit operator Dolar(double cantidad)
        {
            Dolar dolar = new Dolar(cantidad);
            return dolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        public static Dolar operator+(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).cantidad);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).cantidad);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d == (Dolar)e;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return d == (Dolar)p;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Dolar d2)
        {
            return d.cantidad == d2.cantidad;
        }

        public static bool operator !=(Dolar d, Dolar d2)
        {
            return !(d == d2);
        }
    }
}
