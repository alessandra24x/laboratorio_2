using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacionEst) : this(capacidad)
        {
            this.ubicacionEstante = ubicacionEst;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante estante)
        {
            string cadena = string.Empty;

            foreach (Producto auxProducto in estante.productos)
            {
                if (!(auxProducto is null))
                {
                    cadena += estante.ubicacionEstante + " " + Producto.MostrarProducto(auxProducto) + "\n";
                }
            }
            return cadena;
        }

        public static bool operator ==(Estante estante, Producto producto)
        {
            return estante.productos.Contains(producto);
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        public static bool operator +(Estante estante, Producto producto)
        {
            if (estante != producto)
            {
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (estante.productos[i] is null)
                    {
                        estante.productos[i] = producto;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante estante, Producto producto)
        {
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] == producto)
                {
                    estante.productos[i] = null;
                }
            }
            return estante;
        }
    }
}
