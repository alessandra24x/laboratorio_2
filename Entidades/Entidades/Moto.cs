using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        protected short cilindrada;

        public Moto(short cantRuedas, short cantPuertas, Colores color, short cilindrada) : base(cantRuedas, cantPuertas, color)
        {
            this.cilindrada = cilindrada;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Moto");
            sb.Append(base.Mostrar());
            sb.AppendLine($"cilindros: {cilindrada}");
            return sb.ToString();
        }
    }
}
