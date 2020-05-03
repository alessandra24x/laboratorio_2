using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(int capacidadML, int contenidoML, string marca) : this(capacidadML, contenidoML, Tipo.Vidrio, marca) { }

        public Cerveza(int capacidadML, int contenidoML, Tipo tipo, string marca) : base(capacidadML, contenidoML, marca)
        {
            this.tipo = tipo;
        }

        public override int ServirMedida()
        {
            int cantAServir;

            if (MEDIDA < this.contenidoML)
                cantAServir = (MEDIDA / 100) * 80;
            else
                cantAServir = this.contenidoML;

            this.contenidoML -= cantAServir;

            return cantAServir;
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }

        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GenerarInforme());
            sb.AppendLine($"La medida de la cerveza es: {MEDIDA}");
            sb.AppendLine($"El tipo es: {tipo}");
            return sb.ToString();
        }
    }
}
