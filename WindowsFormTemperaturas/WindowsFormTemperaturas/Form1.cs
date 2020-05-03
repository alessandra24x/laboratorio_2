using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormTemperaturas
{
    public partial class FormConversorT : Form
    {
        public FormConversorT()
        {
            InitializeComponent();
            txtFahrenheit.Text = "0";
            txtCelsius.Text = "0";
            txtKelvin.Text = "0";
        }

        private void btnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtFahrenheit.Text, out double aux))
            {
                Fahrenheit f = new Fahrenheit(aux);
                txtFahrenheitAFahrenheit.Text = f.GetCantidad().ToString("0.##");
                txtFahrenheitACelsius.Text = ((Celsius)f).GetCantidad().ToString("0.##");
                txtFahrenheitAKelvin.Text = ((Kelvin)f).GetCantidad().ToString("0.##");
            }

        }

        private void btnConvertCelsius_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double aux))
            {
                Celsius c = new Celsius(aux);
                txtCelsiusACelsius.Text = c.GetCantidad().ToString("0.##");
                txtCelsiusAFahrenheit.Text = ((Fahrenheit)c).GetCantidad().ToString("0.##");
                txtCelsiusAKelvin.Text = ((Kelvin)c).GetCantidad().ToString("0.##");
            }
        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtKelvin.Text, out double aux))
            {
                Kelvin k = new Kelvin(aux);
                txtKelvinAKelvin.Text = k.GetCantidad().ToString("0.##");
                txtKelvinAFahrenheit.Text = ((Fahrenheit)k).GetCantidad().ToString("0.##");
                txtKelvinACelsius.Text = ((Celsius)k).GetCantidad().ToString("0.##");
            }
        }
    }
}
