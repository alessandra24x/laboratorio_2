using ComiqueriaLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Producto productoSeleccionado;
        private Comiqueria comiqueria;

        public VentasForm(Comiqueria comiqueria, Producto productoSeleccionado)
        {
            InitializeComponent();
            this.comiqueria = comiqueria;
            this.productoSeleccionado = productoSeleccionado;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            this.lblDescripcion.Text = this.productoSeleccionado.Descripcion;
            ActualizarPrecio();
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        //private void ActualizarPrecio()
        //{
        //    int cantidadSeleccionada = Convert.ToInt32(this.numericUpDownCantidad.Value);
        //    double nuevoPrecioFinal = Venta.CalcularPrecioFinal(this.productoSeleccionado.Precio, cantidadSeleccionada);
        //    this.lblPrecioFinal.Text = String.Format($"Precio Final: ${0:0.00}", nuevoPrecioFinal);
        //}

        private void ActualizarPrecio()
        {
            int cantidadSeleccionada = Convert.ToInt32(this.numericUpDownCantidad.Value);
            double nuevoPrecioFinal = Venta.CalcularPrecioFinal(this.productoSeleccionado.Precio, cantidadSeleccionada);
            this.lblPrecioFinal.Text = String.Format("Precio Final: ${0:0.00}", nuevoPrecioFinal);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionada = Convert.ToInt32(this.numericUpDownCantidad.Value);

            if (cantidadSeleccionada <= productoSeleccionado.Stock)
            {
                this.comiqueria.Vender(this.productoSeleccionado, cantidadSeleccionada);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Supero la cantidad de productos de este tipo disponibles en stock", "Stock Superado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
