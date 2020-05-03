using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        protected int cantPasajeros;
        protected short cantMarchas;

        public Automovil(int cantPasajeros, short cantRuedas, short cantPuertas, short cantMarchas, Colores color) : base(cantRuedas, cantPuertas, color)
        {
            this.cantPasajeros = cantPasajeros;
            this.cantMarchas = cantMarchas;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Automovil");
            sb.Append(base.Mostrar());
            sb.AppendLine($"cantidad Pasajeros: {cantPasajeros}");
            sb.AppendLine($"cantidad Marchas: {cantMarchas}");
            return sb.ToString();
        }
    }
}
