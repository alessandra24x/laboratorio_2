using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private string nombre;
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            if (equipo.jugadores.Count < equipo.cantidadDeJugadores)
                if(!(equipo.jugadores.Contains(jugador)))
                {
                    equipo.jugadores.Add(jugador);
                    return true;
                }
            return false;
            //foreach (Jugador persona in equipo.jugadores)
            //{
            //    if (persona != jugador)
            //    {
            //        equipo.jugadores.Add(persona);
            //        return true;
            //    }
            //}
        }

        public string MostrarDatosEquipo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del equipo: {nombre}\n" + $"Cantidad de Jugadores:  {cantidadDeJugadores}\n" + $"Jugadores: \n");
            foreach (Jugador persona in jugadores)
            {
                sb.AppendLine(persona.MostrarDatos());
            }

            return sb.ToString();
        }
    }
}
