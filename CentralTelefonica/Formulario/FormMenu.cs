using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Formulario
{
    public partial class FrmMenu : Form
    {
        private Centralita c;

        public FrmMenu()
        {
            InitializeComponent();
            c = new Centralita("Telefonica");
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FormLlamador llamador = new FormLlamador(c);
            llamador.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FormMostrar mostrar = new FormMostrar(c);
            mostrar.Tipo = Llamada.TipoLlamada.Todas;
            mostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FormMostrar mostrar = new FormMostrar(c);
            mostrar.Tipo = Llamada.TipoLlamada.Local;
            mostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FormMostrar mostrar = new FormMostrar(c);
            mostrar.Tipo = Llamada.TipoLlamada.Provincial;
            mostrar.ShowDialog();
        }
    }
}
