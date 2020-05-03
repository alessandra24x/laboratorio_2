using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBoligrafo
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if(this.tinta >= 0 && this.tinta <= cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            if (gasto <= this.tinta)
            {
                this.tinta -= gasto; 
                dibujo = new string('*', gasto);
                return true;
            }
            else
            {
                dibujo = new string('*', this.tinta);
                Console.WriteLine("Gasto mayor al porcentaje de tinta disponible");
                return false;
            }
        }







    }




}
