using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCantidadEspaciosCantina
{
    public partial class FrmCantidadEspacios : Form
    {
        public DialogResult resultado;
        public FrmCantidadEspacios()
        {
            InitializeComponent();
        }

        public short CantidadEspacios
        {
            get
            {
                return (short)numUpDown.Value;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.resultado = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.resultado = DialogResult.OK;
            this.Close();
        }
    }
}
