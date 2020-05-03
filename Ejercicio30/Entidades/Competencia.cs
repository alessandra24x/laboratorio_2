using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private static Random random;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short CantCompetidores, short CantVueltas) : this()
        {
            this.cantidadCompetidores = CantCompetidores;
            this.cantidadVueltas = CantVueltas;
        }

        static Competencia()
        {
            random = new Random();
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nDATOS DE LA COMPETENCIA\n");
            sb.AppendLine($"Cantidad de competidores: {cantidadCompetidores}\n" + $"Cantidad de vueltas: {cantidadVueltas}\n" + $"Competidores:\n");

            foreach (AutoF1 item in competidores)
            {
                sb.AppendLine(item.MostrarDatos());
            }

            return sb.ToString();
        }

        public static bool operator ==(Competencia comp, AutoF1 auto)
        {
            foreach (AutoF1 item in comp.competidores)
            {
                if(item == auto)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Competencia comp, AutoF1 auto)
        {
            return !(comp == auto);
        }

        public static bool operator +(Competencia comp, AutoF1 auto)
        {
            if (comp.competidores.Count < comp.cantidadCompetidores)
            {
                if (comp != auto)
                {
                    comp.competidores.Add(auto);
                    auto.EnCompetencia = true;
                    auto.VueltasRestantes = comp.cantidadVueltas;
                    auto.CantidadCombustible = (short)random.Next(15, 100);
                    return true;
                }
            }
            return false;
        }

        public static bool operator -(Competencia comp, AutoF1 auto)
        {
            if (comp.competidores.Contains(auto))
            {
                comp.competidores.Remove(auto);
                return true;
            }
            return false;
        }
    }
}
