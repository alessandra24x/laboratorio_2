using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Billetes;

namespace Ejercicio23
{
    public partial class FormMonedas : Form
    {
        public FormMonedas()
        {
            InitializeComponent();
            txtCotizacionEuro.Text = Euro.GetCotizacion().ToString("0.##");
            txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString("0.##");
            txtCotizacionPesos.Text = Pesos.GetCotizacion().ToString("0.##");
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if(Validacion.ValidarCampos(txtCotizacionDolar.Text, txtCotizacionEuro.Text, txtCotizacionPesos.Text))
            {
                if(txtCotizacionDolar.Enabled)
                {
                    btnLockCotizacion.Image = imageList1.Images[0];
                    txtCotizacionDolar.Enabled = false;
                    txtCotizacionEuro.Enabled = false;
                    txtCotizacionPesos.Enabled = false;
                } else
                {
                    btnLockCotizacion.Image = imageList1.Images[1];
                    txtCotizacionDolar.Enabled = true;
                    txtCotizacionEuro.Enabled = true;
                    txtCotizacionPesos.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Error, revisen los valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            if(double.TryParse(txtCotizacionEuro.Text, out double aux))
            {
                Euro.SetCotizacion(aux);
            } else
            {
                txtCotizacionEuro.Focus();
            }
        }

        private void txtCotizacionDolar_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtCotizacionDolar.Text, out double aux))
            {
                Dolar.SetCotizacion(aux);
            }
            else
            {
                txtCotizacionDolar.Focus();
            }
        }

        private void txtCotizacionPesos_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtCotizacionPesos.Text, out double aux))
            {
                Pesos.SetCotizacion(aux);
            }
            else
            {
                txtCotizacionPesos.Focus();
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtEuro.Text, out double aux))
            {
                Euro moneda = new Euro(aux);
                txtEuroAEuro.Text = moneda.GetCantidad().ToString("0.##");
                txtEuroADolar.Text = ((Dolar) moneda).GetCantidad().ToString("0.##");
                txtEuroAPesos.Text = ((Pesos) moneda).GetCantidad().ToString("0.##");
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDolar.Text, out double aux))
            {
                Dolar moneda = new Dolar(aux);
                txtDolarADolar.Text = moneda.GetCantidad().ToString("0.##");
                txtDolarAEuro.Text = ((Euro)moneda).GetCantidad().ToString("0.##");
                txtDolarAPesos.Text = ((Pesos)moneda).GetCantidad().ToString("0.##");
            }
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPesos.Text, out double aux))
            {
                Pesos moneda = new Pesos(aux);
                txtPesosAPesos.Text = moneda.GetCantidad().ToString("0.##");
                txtPesosAEuro.Text = ((Euro)moneda).GetCantidad().ToString("0.##");
                txtPesosADolar.Text = ((Dolar)moneda).GetCantidad().ToString("0.##");
            }
        }
    }
}
