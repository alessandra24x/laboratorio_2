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
using ControlCantina;
using WindowsFormsApp;
using FrmCantidadEspaciosCantina;

namespace FrmBar
{
    public partial class MDIParent : Form
    {
        Edificio ed;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            ed = Edificio.GetBar();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCantidadEspacios cantEspacios = new FrmCantidadEspacios();
            cantEspacios.ShowDialog();
            if(cantEspacios.resultado == DialogResult.OK)
            {
                FrmCantina cantina = new FrmCantina(cantEspacios.CantidadEspacios);
                if(ed + cantina.GetCantina)
                {
                    cantina.MdiParent = this;
                    cantina.Show();
                }
            }
        }

    }
}
