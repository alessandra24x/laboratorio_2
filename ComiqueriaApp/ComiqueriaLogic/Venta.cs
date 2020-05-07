using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajelva;
        private double precioFinal;
        private Producto producto;

        static Venta()
        {
            Venta.porcentajelva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }

        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }

        private void Vender(int cantidad)
        {
            producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioSinIva = precioUnidad * cantidad;
            double precioFinal = precioSinIva + precioSinIva * Venta.porcentajelva / 100;
            return precioFinal;
        }

        public string ObtenerDescripcionBreve()
        {
            return string.Format("{0}-{1}-${2:0.00}", this.fecha, this.producto.Descripcion, this.precioFinal);
        }



    }
}
