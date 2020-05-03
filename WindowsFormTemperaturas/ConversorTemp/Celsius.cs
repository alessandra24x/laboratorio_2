using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celsius
    {
        private double cantidad;

        public Celsius(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Celsius(double c)
        {
            return new Celsius(c);
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.cantidad * (9 / 5) + 32); //Celsius a Fahrenheit
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return (Kelvin)((Fahrenheit)c); //Celsius a Fahrenheit y Fahrenheit a Kelvin
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.cantidad + ((Celsius)f).cantidad);
        }

        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.cantidad + ((Celsius)k).cantidad);
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.cantidad - ((Celsius)f).cantidad);
        }

        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(c.cantidad - ((Celsius)k).cantidad);
        }

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.cantidad == c2.cantidad;
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return c == f;
        }

        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            return c == k;
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }
    }
}
