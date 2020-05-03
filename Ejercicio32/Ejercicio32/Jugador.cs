using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        private int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        private float PromedioGoles
        {
            get
            {
                return (float)this.totalGoles / this.partidosJugados;
            }
        }

        private int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        private string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        private int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del jugador: {nombre}\n" +
                $"Dni: {dni}\n" + $"Partidos jugados: {partidosJugados}\n" +
                $"Total Goles: {totalGoles}\n" + $"Promedio Goles: {PromedioGoles}\n");
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
