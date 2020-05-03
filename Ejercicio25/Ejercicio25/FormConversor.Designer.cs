namespace Ejercicio25
{
    partial class FormConversor
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
            this.lblBinario = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBinario
            // 
            this.lblBinario.AutoSize = true;
            this.lblBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinario.Location = new System.Drawing.Point(24, 42);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(124, 18);
            this.lblBinario.TabIndex = 0;
            this.lblBinario.Text = "Binario a Decimal";
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.Location = new System.Drawing.Point(24, 110);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(124, 18);
            this.lblDecimal.TabIndex = 1;
            this.lblDecimal.Text = "Decimal a Binario";
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.Location = new System.Drawing.Point(317, 38);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(75, 23);
            this.btnBinToDec.TabIndex = 2;
            this.btnBinToDec.Text = "->";
            this.btnBinToDec.UseVisualStyleBackColor = true;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.Location = new System.Drawing.Point(317, 105);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(75, 23);
            this.btnDecToBin.TabIndex = 3;
            this.btnDecToBin.Text = "->";
            this.btnDecToBin.UseVisualStyleBackColor = true;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.Enabled = false;
            this.txtResultadoBin.Location = new System.Drawing.Point(428, 106);
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.Size = new System.Drawing.Size(100, 22);
            this.txtResultadoBin.TabIndex = 4;
            this.txtResultadoBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Enabled = false;
            this.txtResultadoDec.Location = new System.Drawing.Point(428, 39);
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.Size = new System.Drawing.Size(100, 22);
            this.txtResultadoDec.TabIndex = 5;
            this.txtResultadoDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(173, 106);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 22);
            this.txtDecimal.TabIndex = 1;
            this.txtDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(173, 38);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 22);
            this.txtBinario.TabIndex = 0;
            this.txtBinario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(582, 155);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.btnBinToDec);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblBinario);
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Name = "FormConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Dinero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinario;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.Button btnDecToBin;
        private System.Windows.Forms.TextBox txtResultadoBin;
        private System.Windows.Forms.TextBox txtResultadoDec;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtBinario;
    }
}

