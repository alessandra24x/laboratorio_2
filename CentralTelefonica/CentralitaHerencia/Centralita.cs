using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;

            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
                {
                    if (llamada is Local)
                        ganancia += ((Local)llamada).CostoLlamada;
                }
                if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
                {
                    if (llamada is Provincial)
                        ganancia += ((Provincial)llamada).CostoLlamada;
                }
            }
            return ganancia;
        }

        public void OrdenarLlamadas()
        {
            Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
                c.AgregarLlamada(nuevaLlamada);
            return c;
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada llActual in c.Llamadas)
            {
                if (llActual == llamada)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon Social: {razonSocial}");
            sb.AppendLine($"Ganancia Total: {GananciasPorTotal}");
            sb.AppendLine($"Ganancia por llamadas locales: {GananciasPorLocal}");
            sb.AppendLine($"Ganancia por llamadas provinciales: {GananciasPorProvincial}\n");
            sb.AppendLine($"Detalle de llamadas: ");

            foreach (Llamada llamada in listaDeLlamadas)
            {
                sb.AppendLine("----------------------------------------------------");
                sb.Append(llamada.ToString());
                sb.AppendLine("---------------------------------------------------");
            }
            sb.AppendLine("\n****************************************************");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
