using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class VehiculoTerrestre
    {
        public enum Colores
        {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
        }

        private short cantRuedas;
        private short cantPuertas;
        protected Colores color;


        public VehiculoTerrestre(short cantRuedas, short cantPuertas, Colores color)
        {
            this.cantRuedas = cantRuedas;
            this.cantPuertas = cantPuertas;
            this.color = color;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"cantidad Ruedas: {cantRuedas}");
            sb.AppendLine($"cantidad Puertas: {cantPuertas}");
            sb.AppendLine($"color: {color}");
            return sb.ToString();
        }
    }
}
