using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fahrenheit
    {
        private double cantidad;

        public Fahrenheit(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Fahrenheit(double c)
        {
            return new Fahrenheit(c);
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.cantidad - 32) * 5 / 9); //Fahrenheit a Celsius
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.cantidad + 459.67) * 5 / 9); //Farenheit a Kelvin
        }

        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.cantidad + ((Fahrenheit)c).cantidad);
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.cantidad + ((Fahrenheit)k).cantidad);
        }

        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.cantidad - ((Fahrenheit)c).cantidad);
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.cantidad - ((Fahrenheit)k).cantidad);
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.cantidad == f2.cantidad;
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return f == (Fahrenheit)c;
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return f == (Fahrenheit)k;
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }
    }
}
