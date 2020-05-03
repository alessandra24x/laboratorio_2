using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{

    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino) { }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }

        }

        private float CalcularCosto()
        {
            if (this.franjaHoraria == Franja.Franja_1)
                return Duracion * (float) 0.99;
            else if (this.franjaHoraria == Franja.Franja_2)
                return Duracion * (float) 1.25;
            else
                return Duracion * (float) 0.66;
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Costo Llamada: {CostoLlamada}");
            sb.AppendLine($"Franja Horaria: {franjaHoraria}");
            sb.AppendLine(base.Mostrar());
            return sb.ToString();
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
