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
    public partial class FormLlamador : Form
    {
        private Centralita centralita;

        public FormLlamador(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        public Centralita Centralita
        {
            get { return this.centralita; }
        }


        private void FormLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            txtNroDeDestino.Text = "Nro de Destino";
            txtNroDeOrigen.Text = "Nro de Origen";
        }

        private void txtNroDeDestino_TextChanged(object sender, EventArgs e)
        {
            if(txtNroDeDestino.Text == "#")
                cmbFranja.Enabled = true;
            else
                cmbFranja.Enabled = false;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if(txtNroDeDestino.Text != "Nro de Destino")
            {
                if (txtNroDeDestino.Text[0] == '#')
                {
                    Provincial.Franja franjas;
                    Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                    Provincial llamada = new Provincial(txtNroDeOrigen.Text, franjas, random.Next(1, 50), txtNroDeDestino.Text);
                    centralita += llamada;
                    txtNroDeDestino.Text = "Nro de Destino";
                    txtNroDeOrigen.Text = "Nro de Origen";

                } else
                {
                    Local llamada = new Local(txtNroDeOrigen.Text, random.Next(1, 50), txtNroDeDestino.Text, random.Next(5,56) / 10);
                    centralita += llamada;
                    txtNroDeDestino.Text = "Nro de Destino";
                    txtNroDeOrigen.Text = "Nro de Origen";
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtNroDeDestino.Text == "Nro de Destino")
            {
                txtNroDeDestino.Text = String.Empty;
            }
            txtNroDeDestino.Text += "1";
            txtNroDeOrigen.Text = "1124743898";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtNroDeDestino.Text == "Nro de Destino")
            {
                txtNroDeDestino.Text = String.Empty;
            }
            txtNroDeDestino.Text += "2";
            txtNroDeOrigen.Text = "1124743898";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtNroDeDestino.Text == "Nro de Destino")
            {
                txtNroDeDestino.Text = String.Empty;
            }
            txtNroDeDestino.Text += "3";
            txtNroDeOrigen.Text = "1124743898";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtNroDeDestino.Text == "Nro de Destino")
            {
                txtNroDeDestino.Text = String.Empty;
            }
            txtNroDeDestino.Text += "4";
            txtNroDeOrigen.Text = "1124743898";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtNroDeDestino.Text == "Nro de Destino")
            {
                txtNroDeDestino.Text = String.Empty;
            }
            txtNroDeDestino.Text += "5";
            txtNroDeOrigen.Text = "1124743898";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtNroDeDestino.Text == "Nro de Destino")
            {
                txtNroDeDestino.Text = String.Empty;
            }
            txtNroDeDestino.Text += "6";
            txtNroDeOrigen.Text = "1124743898";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtNroDeDestino.Text == "Nro de Destino")
            {
                txtNroDeDestino.Text = String.Empty;
            }
            txtNroDeDestino.Text += "7";
            txtNroDeOrigen.Text = "1124743898";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtNroDeDestino.Text == "Nro de Destino")
            {
                txtNroDeDestino.Text = String.Empty;
            }
            txtNroDeDestino.Text += "8";
            txtNroDeOrigen.Text = "1124743898";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtNroDeDestino.Text == "Nro de Destino")
            {
                txtNroDeDestino.Text = String.Empty;
            }
            txtNroDeDestino.Text += "9";
            txtNroDeOrigen.Text = "1124743898";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtNroDeDestino.Text == "Nro de Destino")
            {
                txtNroDeDestino.Text = String.Empty;
            }
            txtNroDeDestino.Text += "0";
            txtNroDeOrigen.Text = "1124743898";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            if (txtNroDeDestino.Text == "Nro de Destino")
            {
                txtNroDeDestino.Text = String.Empty;
            }
            txtNroDeDestino.Text += "*";
            txtNroDeOrigen.Text = "1124743898";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            if (txtNroDeDestino.Text == "Nro de Destino")
            {
                txtNroDeDestino.Text = String.Empty;
            }
            txtNroDeDestino.Text += "#";
            txtNroDeOrigen.Text = "1124743898";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDeDestino.Text = "Nro de Destino";
            txtNroDeOrigen.Text = "Nro de Origen";

        }

        private void txtNroDeOrigen_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
