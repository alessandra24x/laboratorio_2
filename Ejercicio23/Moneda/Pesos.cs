using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 38.33;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public static void SetCotizacion(double cotizacion)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public static implicit operator Pesos(double cantidad)
        {
            Pesos euro = new Pesos(cantidad);
            return euro;
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            Dolar d = (Dolar)p;
            Euro e = (Euro)d;
            return e;
            //return (Euro)((Dolar)p);
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad + ((Pesos)e).cantidad);
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad + ((Pesos)d).cantidad);
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad - ((Pesos)e).cantidad);
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad - ((Pesos)d).cantidad);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p == (Pesos)d;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return p == (Pesos)e;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p, Pesos p2)
        {
            return p == p2;
        }

        public static bool operator !=(Pesos p, Pesos p2)
        {
            return !(p == p2);
        }
    }
}