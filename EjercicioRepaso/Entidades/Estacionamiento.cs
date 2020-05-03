using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private string nombre;
        private Auto[] autos;
        private double precioAuto;
        private static Random numAleatorio;

        public Estacionamiento(string nombre, int capacidadEstacionamiento) : this(capacidadEstacionamiento)
        {
            this.nombre = nombre;
        }

        private Estacionamiento(int capacidadEstacionamiento)
        {
            this.autos = new Auto[capacidadEstacionamiento];
            this.precioAuto = Estacionamiento.GenerarPrecio();
        }
        //el constructor estatico se ejecuta una vez sola en todo el programa, no necesita crear un obj para poder usarlo
        static Estacionamiento()
        {
            numAleatorio = new Random();
        }

        public static int GenerarPrecio()
        {
            return numAleatorio.Next(100, 300);
        }

        public static bool operator ==(Estacionamiento estacionamiento, Auto auto)
        {
            //bool esta = false;
            //foreach (Auto auxAuto in estacionamiento.autos)
            //{
            //    if (!(auxAuto is null))
            //    {
            //        if(auxAuto == auto)
            //        {
            //            esta = true;
            //        }
            //    }
            //}
            //return esta;

            //for(int i = 0; i < estacionamiento.autos.Length; i++)
            //{
            //    if(!(estacionamiento.autos[i] is null))
            //    {
            //        if(estacionamiento.autos[i] == auto)
            //        {
            //            esta = true;
            //        }
            //    }
            //}
            //return esta;
            return estacionamiento.autos.Contains(auto);
        }

        public static bool operator !=(Estacionamiento estacionamiento, Auto auto)
        {
            return !(estacionamiento == auto);
        }

        public static bool operator +(Estacionamiento estacionamiento, Auto auto)
        {
            bool agrego = false;
            if(estacionamiento != auto)
            {
                for(int i = 0; i < estacionamiento.autos.Length; i++)
                {
                    if(estacionamiento.autos is null)
                    {
                        estacionamiento.autos[i] = auto;
                        agrego = true;
                        break;
                    }
                }
            }
            return agrego;
        }

        public static implicit operator Estacionamiento(int capacidad)
        {
            return new Estacionamiento(capacidad);
        }

    }
}
