using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string patente;
        private string marca;
        private int cantPuertas;
        private int dni;
        
        public Auto(string patente, string marca, int cantPuertas, int dni) : this(patente, dni)
        {
            this.marca = marca;
            this.cantPuertas = cantPuertas;
        }

        public Auto(string patente, int dni) : this()
        {
            this.patente = patente;
            this.dni = dni;
        }

        private Auto()
        {
            this.marca = "Dato no ingresado";
            this.cantPuertas = -1;
        }

        public string GetInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {this.patente}");
            sb.AppendFormat("Marca: {0}\n", this.marca);

            if (this.cantPuertas != -1)
            {
                sb.AppendLine("Cantidad Puertas: " + this.cantPuertas);
            } else
            {
                sb.AppendLine("Cantidad puertas: no se ingresó este dato");
            }

            sb.AppendLine($"DNI: {this.dni}");
            return sb.ToString();
        }

        public void SetInformacion(int cantPuertas)
        {
            this.cantPuertas = cantPuertas;
        }

        public void SetInformacion(string marca)
        {
            this.marca = marca;
        }

        public void SetInformacion(string marca, int cantPuertas)
        {
            this.SetInformacion(marca);
            this.SetInformacion(cantPuertas);
        }

        public static bool operator ==(Auto autoA, Auto autoB)
        {
            // Ctrl K C
            //bool iguales = false;
            //if (autoA.patente == autoB.patente)
            //{
            //    iguales = true;
            //}
            //return iguales;
            return autoA.patente == autoB.patente;          
        }

        public static bool operator !=(Auto autoA, Auto autoB)
        {
            //bool iguales = true;
            //if (autoA.patente == autoB.patente)
            //{
            //    iguales = false;
            //}
            //return iguales;
            return !(autoA == autoB);
        }

        public static explicit operator string(Auto auto)
        {
            return auto.GetInformacion();
        }

       
    }
}
