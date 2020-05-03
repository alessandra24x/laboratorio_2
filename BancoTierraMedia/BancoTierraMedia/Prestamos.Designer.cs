namespace BancoTierraMedia
{
    partial class Prestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.saludo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConfirmarSolicitud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatosPersonales = new System.Windows.Forms.Panel();
            this.lugares = new System.Windows.Forms.ComboBox();
            this.razas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatosPrestamo = new System.Windows.Forms.Panel();
            this.monto = new System.Windows.Forms.TextBox();
            this.cuotas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DatosPersonales.SuspendLayout();
            this.DatosPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludo.ForeColor = System.Drawing.Color.Maroon;
            this.saludo.Location = new System.Drawing.Point(53, 57);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(192, 36);
            this.saludo.TabIndex = 0;
            this.saludo.Text = "Bienvenido, ";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.OrangeRed;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(680, 374);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(98, 58);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConfirmarSolicitud
            // 
            this.btnConfirmarSolicitud.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnConfirmarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarSolicitud.Location = new System.Drawing.Point(331, 323);
            this.btnConfirmarSolicitud.Name = "btnConfirmarSolicitud";
            this.btnConfirmarSolicitud.Size = new System.Drawing.Size(141, 99);
            this.btnConfirmarSolicitud.TabIndex = 2;
            this.btnConfirmarSolicitud.Text = "Confirmar Solicitud";
            this.btnConfirmarSolicitud.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos Personales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(455, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalles del Préstamo:";
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.BackColor = System.Drawing.Color.SandyBrown;
            this.DatosPersonales.Controls.Add(this.lugares);
            this.DatosPersonales.Controls.Add(this.razas);
            this.DatosPersonales.Controls.Add(this.label4);
            this.DatosPersonales.Controls.Add(this.label3);
            this.DatosPersonales.Location = new System.Drawing.Point(41, 193);
            this.DatosPersonales.Name = "DatosPersonales";
            this.DatosPersonales.Size = new System.Drawing.Size(344, 113);
            this.DatosPersonales.TabIndex = 5;
            // 
            // lugares
            // 
            this.lugares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lugares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lugares.FormattingEnabled = true;
            this.lugares.Location = new System.Drawing.Point(195, 69);
            this.lugares.Name = "lugares";
            this.lugares.Size = new System.Drawing.Size(121, 24);
            this.lugares.TabIndex = 3;
            // 
            // razas
            // 
            this.razas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.razas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.razas.FormattingEnabled = true;
            this.razas.Location = new System.Drawing.Point(195, 21);
            this.razas.Name = "razas";
            this.razas.Size = new System.Drawing.Size(121, 24);
            this.razas.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(22, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lugar de Origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(123, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Raza:";
            // 
            // DatosPrestamo
            // 
            this.DatosPrestamo.BackColor = System.Drawing.Color.SandyBrown;
            this.DatosPrestamo.Controls.Add(this.monto);
            this.DatosPrestamo.Controls.Add(this.cuotas);
            this.DatosPrestamo.Controls.Add(this.label5);
            this.DatosPrestamo.Controls.Add(this.label6);
            this.DatosPrestamo.Location = new System.Drawing.Point(424, 193);
            this.DatosPrestamo.Name = "DatosPrestamo";
            this.DatosPrestamo.Size = new System.Drawing.Size(354, 113);
            this.DatosPrestamo.TabIndex = 6;
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(222, 21);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(121, 22);
            this.monto.TabIndex = 5;
            // 
            // cuotas
            // 
            this.cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuotas.FormattingEnabled = true;
            this.cuotas.Location = new System.Drawing.Point(222, 69);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(121, 24);
            this.cuotas.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(14, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Monto del Préstamo:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(136, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cuotas:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.DatosPrestamo);
            this.Controls.Add(this.DatosPersonales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmarSolicitud);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.DatosPersonales.ResumeLayout(false);
            this.DatosPersonales.PerformLayout();
            this.DatosPrestamo.ResumeLayout(false);
            this.DatosPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConfirmarSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DatosPersonales;
        private System.Windows.Forms.ComboBox lugares;
        private System.Windows.Forms.ComboBox razas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel DatosPrestamo;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.ComboBox cuotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}