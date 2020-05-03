namespace WindowsFormsApp
{
    partial class FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.barra = new ControlCantina.Barra();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cerveza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agua";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(184, 424);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(248, 22);
            this.txtMarca.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(332, 492);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(184, 492);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(72, 22);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(483, 422);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(186, 24);
            this.cmbBotellaTipo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(483, 462);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(186, 52);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 423);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 479);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(181, 400);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca";
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(480, 400);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(83, 17);
            this.lblBotellaTipo.TabIndex = 10;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // barra
            // 
            this.barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra.BackgroundImage")));
            this.barra.Location = new System.Drawing.Point(13, 13);
            this.barra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(566, 356);
            this.barra.TabIndex = 11;
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(329, 472);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(72, 17);
            this.lblContenido.TabIndex = 12;
            this.lblContenido.Text = "Contenido";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(181, 472);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(75, 17);
            this.lblCapacidad.TabIndex = 13;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 542);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.lblBotellaTipo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCantina";
            this.Text = "Alumno Alessandra Fernandes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCantina_FormClosing);
            this.Load += new System.EventHandler(this.FrmCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblBotellaTipo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ControlCantina.Barra barra;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblCapacidad;
    }
}

