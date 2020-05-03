using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        public int numero;

        private NumeroDecimal(int n)
        {
            this.numero = n;
        }

        public int GetNumero()
        {
            return this.numero;
        }

        public static implicit operator NumeroDecimal(int n)
        {
            return new NumeroDecimal(n);
        }

        public static explicit operator NumeroBinario(NumeroDecimal n)
        {
            return Conversor.DecimalBinario(n.numero);
        }

        public static NumeroDecimal operator +(NumeroDecimal num1, NumeroDecimal num2)
        {
            return new NumeroDecimal(num1.numero + num2.numero);
        }

        public static int operator+(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return (numeroDecimal.numero + ((NumeroDecimal)numeroBinario).numero);
        }

        public static NumeroDecimal operator -(NumeroDecimal num1, NumeroDecimal num2)
        {
            return new NumeroDecimal(num1.numero - num2.numero);
        }

        public static int operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return (numeroDecimal.numero - ((NumeroDecimal)numeroBinario)).numero;
        }

        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return (numeroDecimal.numero == ((NumeroDecimal)numeroBinario).numero);
        }

        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return !(numeroDecimal == numeroBinario);
        }
    }
}
