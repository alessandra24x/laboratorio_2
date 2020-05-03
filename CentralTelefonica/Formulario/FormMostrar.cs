using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormMostrar : Form
    {
        private Centralita centralita;
        public Llamada.TipoLlamada tipo;

        public FormMostrar(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        public Llamada.TipoLlamada Tipo
        {
            set
            {
                this.tipo = value;
            }
        }

        private void FormMostrar_Load(object sender, EventArgs e)
        {
            if (tipo == Llamada.TipoLlamada.Local)
                richTxtResultado.AppendText($"Facturación por llamadas Locales: {centralita.GananciasPorLocal.ToString()}");
            else if (tipo == Llamada.TipoLlamada.Provincial)
                richTxtResultado.AppendText($"Facturación por llamadas Provinciales: {centralita.GananciasPorProvincial.ToString()}");
            else
                richTxtResultado.AppendText($"Facturación por llamadas Totales: {centralita.ToString()}");
        }
    }
}

