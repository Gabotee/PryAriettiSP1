namespace PryAriettiSP1
{
    partial class FrmProduccion
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
            this.lblTituloProduccion = new System.Windows.Forms.Label();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.lblLocalidadProduccion = new System.Windows.Forms.Label();
            this.lstLocalidades = new System.Windows.Forms.ComboBox();
            this.lstCultivo = new System.Windows.Forms.ComboBox();
            this.txtToneladas = new System.Windows.Forms.TextBox();
            this.cmdCargarToneladas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloProduccion
            // 
            this.lblTituloProduccion.AutoSize = true;
            this.lblTituloProduccion.Location = new System.Drawing.Point(61, 29);
            this.lblTituloProduccion.Name = "lblTituloProduccion";
            this.lblTituloProduccion.Size = new System.Drawing.Size(115, 13);
            this.lblTituloProduccion.TabIndex = 0;
            this.lblTituloProduccion.Text = "Ingrese Las Toneladas";
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Location = new System.Drawing.Point(25, 94);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(39, 13);
            this.lblCultivo.TabIndex = 1;
            this.lblCultivo.Text = "Cultivo";
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Location = new System.Drawing.Point(25, 122);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(57, 13);
            this.lblToneladas.TabIndex = 2;
            this.lblToneladas.Text = "Toneladas";
            // 
            // lblLocalidadProduccion
            // 
            this.lblLocalidadProduccion.AutoSize = true;
            this.lblLocalidadProduccion.Location = new System.Drawing.Point(25, 68);
            this.lblLocalidadProduccion.Name = "lblLocalidadProduccion";
            this.lblLocalidadProduccion.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidadProduccion.TabIndex = 3;
            this.lblLocalidadProduccion.Text = "Localidad";
            // 
            // lstLocalidades
            // 
            this.lstLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidades.FormattingEnabled = true;
            this.lstLocalidades.Location = new System.Drawing.Point(106, 68);
            this.lstLocalidades.Name = "lstLocalidades";
            this.lstLocalidades.Size = new System.Drawing.Size(121, 21);
            this.lstLocalidades.TabIndex = 4;
            // 
            // lstCultivo
            // 
            this.lstCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCultivo.FormattingEnabled = true;
            this.lstCultivo.Location = new System.Drawing.Point(106, 95);
            this.lstCultivo.Name = "lstCultivo";
            this.lstCultivo.Size = new System.Drawing.Size(121, 21);
            this.lstCultivo.TabIndex = 5;
            // 
            // txtToneladas
            // 
            this.txtToneladas.Location = new System.Drawing.Point(106, 122);
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(100, 20);
            this.txtToneladas.TabIndex = 6;
            // 
            // cmdCargarToneladas
            // 
            this.cmdCargarToneladas.Location = new System.Drawing.Point(77, 168);
            this.cmdCargarToneladas.Name = "cmdCargarToneladas";
            this.cmdCargarToneladas.Size = new System.Drawing.Size(88, 27);
            this.cmdCargarToneladas.TabIndex = 7;
            this.cmdCargarToneladas.Text = "Cargar";
            this.cmdCargarToneladas.UseVisualStyleBackColor = true;
            this.cmdCargarToneladas.Click += new System.EventHandler(this.cmdCargarToneladas_Click);
            // 
            // FrmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 227);
            this.Controls.Add(this.cmdCargarToneladas);
            this.Controls.Add(this.txtToneladas);
            this.Controls.Add(this.lstCultivo);
            this.Controls.Add(this.lstLocalidades);
            this.Controls.Add(this.lblLocalidadProduccion);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.lblTituloProduccion);
            this.Name = "FrmProduccion";
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.FrmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloProduccion;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.Label lblLocalidadProduccion;
        private System.Windows.Forms.ComboBox lstLocalidades;
        private System.Windows.Forms.ComboBox lstCultivo;
        private System.Windows.Forms.TextBox txtToneladas;
        private System.Windows.Forms.Button cmdCargarToneladas;
    }
}