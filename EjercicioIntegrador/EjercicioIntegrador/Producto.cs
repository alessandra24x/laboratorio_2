using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("La marca es {0}.", p.marca);
            sb.AppendFormat(" El precio es {0}.", p.precio);
            sb.AppendFormat(" El codigo de barra es {0}", p.codigoDeBarra);
            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            return (productoUno.codigoDeBarra == productoDos.codigoDeBarra &&
                    productoUno.marca == productoDos.marca);
        }

        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno == productoDos);
        }

        public static bool operator ==(Producto producto, string marca)
        {
            return producto.GetMarca() == marca;
        }

        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto == marca);
        }
    }
}
