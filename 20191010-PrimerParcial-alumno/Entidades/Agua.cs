using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int MEDIDA = 400;

        public Agua(int capacidadML, int contenidoML, string marca) : base(capacidadML, contenidoML, marca) { }

        public override int ServirMedida()
        {
            return ServirMedida(MEDIDA);
        }

        public int ServirMedida(int servirMedida)
        {
            int cantAServir = 0;

            if(MEDIDA < this.contenidoML)
                cantAServir = servirMedida;
            else
                cantAServir = this.contenidoML;

            this.contenidoML -= cantAServir;

            return cantAServir;
        }

        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GenerarInforme());
            sb.AppendLine($"La medida del agua es: {MEDIDA}");
            return sb.ToString();
        }
    }
}
