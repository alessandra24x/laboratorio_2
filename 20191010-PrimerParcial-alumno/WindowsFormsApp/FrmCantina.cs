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

namespace WindowsFormsApp
{
    public partial class FrmCantina : Form
    {
        public int n;
        public FrmCantina(short n)
        {
            this.n = n;
            this.barra.SetCantina = new Cantina(n);
        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        public Cantina GetCantina
        {
            get
            {
                return this.barra.GetCantina;
            }
        }

        public string GetInforme
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (Botella b in this.barra.GetCantina.Botellas)
                {
                    sb.AppendLine(b);
                }
                return sb.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                Botella.Tipo tipo;
                Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
                Cerveza beer = new Cerveza((int)numericUpDown1.Value, (int)numericUpDown2.Value, tipo, txtMarca.Text);
                barra.AgregarBotella(beer);
            }
            if(radioButton2.Checked)
            {
                Agua water = new Agua((int)numericUpDown1.Value, (int)numericUpDown2.Value, txtMarca.Text);
                barra.AgregarBotella(water);
            }
        }

        private void FrmCantina_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }
    }
}
