namespace Formulario
{
    partial class FormMostrar
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
            this.richTxtResultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTxtResultado
            // 
            this.richTxtResultado.Location = new System.Drawing.Point(40, 56);
            this.richTxtResultado.Name = "richTxtResultado";
            this.richTxtResultado.Size = new System.Drawing.Size(509, 259);
            this.richTxtResultado.TabIndex = 0;
            this.richTxtResultado.Text = "";
            // 
            // FormMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 383);
            this.Controls.Add(this.richTxtResultado);
            this.Name = "FormMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.FormMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtResultado;
    }
}