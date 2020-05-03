using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        protected short cantMarchas;
        protected int pesoCarga;

        public Camion(short cantRuedas, short cantPuertas, Colores color, short cantMarchas, int pesoCarga) : base(cantRuedas, cantPuertas, color)
        {
            this.cantMarchas = cantMarchas;
            this.pesoCarga = pesoCarga;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Camion");
            sb.Append(base.Mostrar());
            sb.AppendLine($"cantidad Marchas: {cantMarchas}");
            sb.AppendLine($"peso carga: {pesoCarga}");
            return sb.ToString();
        }
    }
}
