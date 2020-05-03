using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        protected Botella(int capacidadML, int contenidoML, string marca)
        {
            this.capacidadML = capacidadML;
            this.contenidoML = contenidoML;
            this.marca = marca;
            if (capacidadML < contenidoML)
            {
                this.contenidoML = capacidadML;
            }
        }

        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }

        public float PorcentajeContenido
        {
            get
            {
                return this.contenidoML / this.capacidadML * 100;
            }
        }

        public abstract int ServirMedida();

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"La capacidad de la botella es: {capacidadML.ToString()}");
            sb.AppendFormat($"El contenido de la botella es: {contenidoML.ToString()}");
            sb.AppendFormat($"La marca de la botella es: {marca.ToString()}");
            sb.AppendLine("-------------------------------");
            return sb.ToString();
        }

        public static implicit operator string(Botella b)
        {
            return (string)b;
        }

        public static bool operator ==(Botella botella1, Botella botella2)
        {
            if (!(botella1 is null && botella2 is null))
                if (botella1.marca == botella2.marca)
                    return true;
            return false;
        }

        public static bool operator !=(Botella botella1, Botella botella2)
        {
            return !(botella1 == botella2);
        }

        //public string ToString()
        //{
        //    return this.GenerarInforme();
        //}

        public enum Tipo
        {
            Vidrio,
            Plastico
        }
    }
}
