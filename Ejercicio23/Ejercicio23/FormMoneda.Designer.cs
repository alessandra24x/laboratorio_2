namespace Ejercicio23
{
    partial class FormMonedas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonedas));
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPesos = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroAPesos = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionPesos = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtPesosADolar = new System.Windows.Forms.TextBox();
            this.txtPesosAPesos = new System.Windows.Forms.TextBox();
            this.txtDolarAPesos = new System.Windows.Forms.TextBox();
            this.txtPesosAEuro = new System.Windows.Forms.TextBox();
            this.lblEuroA = new System.Windows.Forms.Label();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPesos = new System.Windows.Forms.Button();
            this.lblDolarA = new System.Windows.Forms.Label();
            this.lblPesosA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(12, 89);
            this.lblEuro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(38, 16);
            this.lblEuro.TabIndex = 0;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(12, 126);
            this.lblDolar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(42, 16);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesos.Location = new System.Drawing.Point(12, 167);
            this.lblPesos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(47, 16);
            this.lblPesos.TabIndex = 2;
            this.lblPesos.Text = "Pesos";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(66, 89);
            this.txtEuro.Margin = new System.Windows.Forms.Padding(2);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(77, 20);
            this.txtEuro.TabIndex = 3;
            this.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(66, 126);
            this.txtDolar.Margin = new System.Windows.Forms.Padding(2);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(77, 20);
            this.txtDolar.TabIndex = 4;
            this.txtDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(66, 167);
            this.txtPesos.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(77, 20);
            this.txtPesos.TabIndex = 5;
            this.txtPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.Location = new System.Drawing.Point(67, 23);
            this.lblCotizacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(82, 18);
            this.lblCotizacion.TabIndex = 6;
            this.lblCotizacion.Text = "Cotización";
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.CausesValidation = false;
            this.txtDolarAEuro.Enabled = false;
            this.txtDolarAEuro.Location = new System.Drawing.Point(231, 129);
            this.txtDolarAEuro.Margin = new System.Windows.Forms.Padding(2);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(77, 20);
            this.txtDolarAEuro.TabIndex = 7;
            this.txtDolarAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuroAPesos
            // 
            this.txtEuroAPesos.CausesValidation = false;
            this.txtEuroAPesos.Enabled = false;
            this.txtEuroAPesos.Location = new System.Drawing.Point(430, 88);
            this.txtEuroAPesos.Margin = new System.Windows.Forms.Padding(2);
            this.txtEuroAPesos.Name = "txtEuroAPesos";
            this.txtEuroAPesos.Size = new System.Drawing.Size(77, 20);
            this.txtEuroAPesos.TabIndex = 8;
            this.txtEuroAPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.CausesValidation = false;
            this.txtEuroADolar.Enabled = false;
            this.txtEuroADolar.Location = new System.Drawing.Point(332, 87);
            this.txtEuroADolar.Margin = new System.Windows.Forms.Padding(2);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(77, 20);
            this.txtEuroADolar.TabIndex = 9;
            this.txtEuroADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.CausesValidation = false;
            this.txtEuroAEuro.Enabled = false;
            this.txtEuroAEuro.Location = new System.Drawing.Point(231, 89);
            this.txtEuroAEuro.Margin = new System.Windows.Forms.Padding(2);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(77, 20);
            this.txtEuroAEuro.TabIndex = 10;
            this.txtEuroAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCotizacionPesos
            // 
            this.txtCotizacionPesos.Location = new System.Drawing.Point(430, 23);
            this.txtCotizacionPesos.Margin = new System.Windows.Forms.Padding(2);
            this.txtCotizacionPesos.Name = "txtCotizacionPesos";
            this.txtCotizacionPesos.Size = new System.Drawing.Size(77, 20);
            this.txtCotizacionPesos.TabIndex = 11;
            this.txtCotizacionPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCotizacionPesos.TextChanged += new System.EventHandler(this.txtCotizacionPesos_TextChanged);
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Location = new System.Drawing.Point(332, 23);
            this.txtCotizacionDolar.Margin = new System.Windows.Forms.Padding(2);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(77, 20);
            this.txtCotizacionDolar.TabIndex = 12;
            this.txtCotizacionDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCotizacionDolar.TextChanged += new System.EventHandler(this.txtCotizacionDolar_TextChanged);
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(231, 23);
            this.txtCotizacionEuro.Margin = new System.Windows.Forms.Padding(2);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(77, 20);
            this.txtCotizacionEuro.TabIndex = 13;
            this.txtCotizacionEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCotizacionEuro.Leave += new System.EventHandler(this.txtCotizacionEuro_Leave);
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.CausesValidation = false;
            this.txtDolarADolar.Enabled = false;
            this.txtDolarADolar.Location = new System.Drawing.Point(332, 129);
            this.txtDolarADolar.Margin = new System.Windows.Forms.Padding(2);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(77, 20);
            this.txtDolarADolar.TabIndex = 14;
            this.txtDolarADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesosADolar
            // 
            this.txtPesosADolar.CausesValidation = false;
            this.txtPesosADolar.Enabled = false;
            this.txtPesosADolar.Location = new System.Drawing.Point(332, 167);
            this.txtPesosADolar.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesosADolar.Name = "txtPesosADolar";
            this.txtPesosADolar.Size = new System.Drawing.Size(77, 20);
            this.txtPesosADolar.TabIndex = 15;
            this.txtPesosADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesosAPesos
            // 
            this.txtPesosAPesos.CausesValidation = false;
            this.txtPesosAPesos.Enabled = false;
            this.txtPesosAPesos.Location = new System.Drawing.Point(430, 167);
            this.txtPesosAPesos.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesosAPesos.Name = "txtPesosAPesos";
            this.txtPesosAPesos.Size = new System.Drawing.Size(77, 20);
            this.txtPesosAPesos.TabIndex = 16;
            this.txtPesosAPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDolarAPesos
            // 
            this.txtDolarAPesos.CausesValidation = false;
            this.txtDolarAPesos.Enabled = false;
            this.txtDolarAPesos.Location = new System.Drawing.Point(430, 129);
            this.txtDolarAPesos.Margin = new System.Windows.Forms.Padding(2);
            this.txtDolarAPesos.Name = "txtDolarAPesos";
            this.txtDolarAPesos.Size = new System.Drawing.Size(77, 20);
            this.txtDolarAPesos.TabIndex = 17;
            this.txtDolarAPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesosAEuro
            // 
            this.txtPesosAEuro.CausesValidation = false;
            this.txtPesosAEuro.Enabled = false;
            this.txtPesosAEuro.Location = new System.Drawing.Point(231, 167);
            this.txtPesosAEuro.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesosAEuro.Name = "txtPesosAEuro";
            this.txtPesosAEuro.Size = new System.Drawing.Size(77, 20);
            this.txtPesosAEuro.TabIndex = 18;
            this.txtPesosAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEuroA
            // 
            this.lblEuroA.AutoSize = true;
            this.lblEuroA.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroA.Location = new System.Drawing.Point(256, 66);
            this.lblEuroA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(38, 16);
            this.lblEuroA.TabIndex = 19;
            this.lblEuroA.Text = "Euro";
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.ImageIndex = 1;
            this.btnLockCotizacion.ImageList = this.imageList1;
            this.btnLockCotizacion.Location = new System.Drawing.Point(153, 11);
            this.btnLockCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(56, 40);
            this.btnLockCotizacion.TabIndex = 20;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bloqueado.png");
            this.imageList1.Images.SetKeyName(1, "desbloqueado.png");
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(153, 87);
            this.btnConvertEuro.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(56, 19);
            this.btnConvertEuro.TabIndex = 21;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(153, 128);
            this.btnConvertDolar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(56, 19);
            this.btnConvertDolar.TabIndex = 22;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPesos
            // 
            this.btnConvertPesos.Location = new System.Drawing.Point(153, 167);
            this.btnConvertPesos.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvertPesos.Name = "btnConvertPesos";
            this.btnConvertPesos.Size = new System.Drawing.Size(56, 19);
            this.btnConvertPesos.TabIndex = 23;
            this.btnConvertPesos.Text = "->";
            this.btnConvertPesos.UseVisualStyleBackColor = true;
            this.btnConvertPesos.Click += new System.EventHandler(this.btnConvertPesos_Click);
            // 
            // lblDolarA
            // 
            this.lblDolarA.AutoSize = true;
            this.lblDolarA.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarA.Location = new System.Drawing.Point(352, 66);
            this.lblDolarA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDolarA.Name = "lblDolarA";
            this.lblDolarA.Size = new System.Drawing.Size(42, 16);
            this.lblDolarA.TabIndex = 24;
            this.lblDolarA.Text = "Dolar";
            // 
            // lblPesosA
            // 
            this.lblPesosA.AutoSize = true;
            this.lblPesosA.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesosA.Location = new System.Drawing.Point(443, 67);
            this.lblPesosA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesosA.Name = "lblPesosA";
            this.lblPesosA.Size = new System.Drawing.Size(47, 16);
            this.lblPesosA.TabIndex = 25;
            this.lblPesosA.Text = "Pesos";
            // 
            // FormMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(542, 219);
            this.Controls.Add(this.lblPesosA);
            this.Controls.Add(this.lblDolarA);
            this.Controls.Add(this.btnConvertPesos);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.lblEuroA);
            this.Controls.Add(this.txtPesosAEuro);
            this.Controls.Add(this.txtDolarAPesos);
            this.Controls.Add(this.txtPesosAPesos);
            this.Controls.Add(this.txtPesosADolar);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionPesos);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAPesos);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(558, 258);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(558, 258);
            this.Name = "FormMonedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMoneda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtEuroAPesos;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtCotizacionPesos;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtPesosADolar;
        private System.Windows.Forms.TextBox txtPesosAPesos;
        private System.Windows.Forms.TextBox txtDolarAPesos;
        private System.Windows.Forms.TextBox txtPesosAEuro;
        private System.Windows.Forms.Label lblEuroA;
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPesos;
        private System.Windows.Forms.Label lblDolarA;
        private System.Windows.Forms.Label lblPesosA;
        private System.Windows.Forms.ImageList imageList1;
    }
}

