using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string n)
        {
            this.numero = n;
        }

        public string GetNumero()
        {
            return this.numero;
        }

        public static implicit operator NumeroBinario(string n)
        {
            return new NumeroBinario(n);
        }

        public static explicit operator NumeroDecimal(NumeroBinario n)
        {
            return Conversor.BinarioDecimal(n.numero);
        }

        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            NumeroDecimal num = (NumeroDecimal)numeroBinario; //convierto el binario en decimal para poder hacer una suma comun y corriente
            return ((NumeroBinario)(num + numeroDecimal)).numero; //devuelvo el resultado en binario haciendo la conversion correspondiente
        }

        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            NumeroDecimal num = (NumeroDecimal)numeroBinario; //convierto el binario en decimal para poder hacer una resta comun y corriente 
            return ((NumeroBinario)(num - numeroDecimal)).numero; //devuelvo el resultado en binario haciendo la conversion correspondiente
            //return ((NumeroBinario) ((NumeroDecimal)numeroBinario - numeroDecimal)).numero;
        }

        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return (numeroBinario.numero == ((NumeroBinario)numeroDecimal).numero);
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario == numeroDecimal);
        }

    }
}
