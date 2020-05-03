using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Entidades;

namespace Ejercicio25
{
    public partial class FormConversor : Form
    {
        public FormConversor()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            NumeroBinario bin = txtBinario.Text;
            if (Validacion.ValidarCampos(txtBinario.Text) && Conversor.isBinary(txtBinario.Text))
            {
                txtResultadoDec.Text = ((NumeroDecimal)bin).GetNumero().ToString("#0");
            }
            else
            {
                MessageBox.Show("Error, revisen los valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDecimal.Text, out int aux) && Validacion.ValidarCampos(txtDecimal.Text))
            {
                NumeroDecimal dec = aux;
                txtResultadoBin.Text = ((NumeroBinario)dec).GetNumero().ToString();
            }
            else
            {
                MessageBox.Show("Error, revisen los valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

