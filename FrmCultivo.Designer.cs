namespace PryAriettiSP1
{
    partial class FrmCultivo
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
            this.lblTituloCultivo = new System.Windows.Forms.Label();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.lblIdentificacionCultivo = new System.Windows.Forms.Label();
            this.txtCultivos = new System.Windows.Forms.TextBox();
            this.txtIdentificacionCultivo = new System.Windows.Forms.TextBox();
            this.cmdCargraCultivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloCultivo
            // 
            this.lblTituloCultivo.AutoSize = true;
            this.lblTituloCultivo.Location = new System.Drawing.Point(59, 26);
            this.lblTituloCultivo.Name = "lblTituloCultivo";
            this.lblTituloCultivo.Size = new System.Drawing.Size(87, 13);
            this.lblTituloCultivo.TabIndex = 0;
            this.lblTituloCultivo.Text = "Ingrese el cultivo";
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Location = new System.Drawing.Point(12, 100);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(39, 13);
            this.lblCultivo.TabIndex = 1;
            this.lblCultivo.Text = "Cultivo";
            // 
            // lblIdentificacionCultivo
            // 
            this.lblIdentificacionCultivo.AutoSize = true;
            this.lblIdentificacionCultivo.Location = new System.Drawing.Point(12, 62);
            this.lblIdentificacionCultivo.Name = "lblIdentificacionCultivo";
            this.lblIdentificacionCultivo.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacionCultivo.TabIndex = 2;
            this.lblIdentificacionCultivo.Text = "Identificacion";
            // 
            // txtCultivos
            // 
            this.txtCultivos.Location = new System.Drawing.Point(88, 100);
            this.txtCultivos.Name = "txtCultivos";
            this.txtCultivos.Size = new System.Drawing.Size(100, 20);
            this.txtCultivos.TabIndex = 3;
            // 
            // txtIdentificacionCultivo
            // 
            this.txtIdentificacionCultivo.Location = new System.Drawing.Point(88, 62);
            this.txtIdentificacionCultivo.Name = "txtIdentificacionCultivo";
            this.txtIdentificacionCultivo.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacionCultivo.TabIndex = 4;
            // 
            // cmdCargraCultivo
            // 
            this.cmdCargraCultivo.Location = new System.Drawing.Point(71, 156);
            this.cmdCargraCultivo.Name = "cmdCargraCultivo";
            this.cmdCargraCultivo.Size = new System.Drawing.Size(75, 23);
            this.cmdCargraCultivo.TabIndex = 5;
            this.cmdCargraCultivo.Text = "Cargar";
            this.cmdCargraCultivo.UseVisualStyleBackColor = true;
            this.cmdCargraCultivo.Click += new System.EventHandler(this.cmdCargraCultivo_Click);
            // 
            // FrmCultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 207);
            this.Controls.Add(this.cmdCargraCultivo);
            this.Controls.Add(this.txtIdentificacionCultivo);
            this.Controls.Add(this.txtCultivos);
            this.Controls.Add(this.lblIdentificacionCultivo);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.lblTituloCultivo);
            this.Name = "FrmCultivo";
            this.Text = "Cultivo";
            this.Load += new System.EventHandler(this.FrmCultivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCultivo;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.Label lblIdentificacionCultivo;
        private System.Windows.Forms.TextBox txtCultivos;
        private System.Windows.Forms.TextBox txtIdentificacionCultivo;
        private System.Windows.Forms.Button cmdCargraCultivo;
    }
}