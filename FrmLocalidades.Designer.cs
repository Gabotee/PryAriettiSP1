namespace PryAriettiSP1
{
    partial class FrmLocalidades
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtIdentificacionLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblIdentificacionLocalidad = new System.Windows.Forms.Label();
            this.cmdCargarLocalidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(68, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(105, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingresar la Localidad";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(94, 96);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtLocalidad.TabIndex = 1;
            // 
            // txtIdentificacionLocalidad
            // 
            this.txtIdentificacionLocalidad.Location = new System.Drawing.Point(94, 63);
            this.txtIdentificacionLocalidad.Name = "txtIdentificacionLocalidad";
            this.txtIdentificacionLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacionLocalidad.TabIndex = 2;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(12, 96);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 3;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblIdentificacionLocalidad
            // 
            this.lblIdentificacionLocalidad.AutoSize = true;
            this.lblIdentificacionLocalidad.Location = new System.Drawing.Point(12, 63);
            this.lblIdentificacionLocalidad.Name = "lblIdentificacionLocalidad";
            this.lblIdentificacionLocalidad.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacionLocalidad.TabIndex = 4;
            this.lblIdentificacionLocalidad.Text = "Identificacion";
            // 
            // cmdCargarLocalidad
            // 
            this.cmdCargarLocalidad.Location = new System.Drawing.Point(71, 157);
            this.cmdCargarLocalidad.Name = "cmdCargarLocalidad";
            this.cmdCargarLocalidad.Size = new System.Drawing.Size(75, 23);
            this.cmdCargarLocalidad.TabIndex = 5;
            this.cmdCargarLocalidad.Text = "Cargar";
            this.cmdCargarLocalidad.UseVisualStyleBackColor = true;
            this.cmdCargarLocalidad.Click += new System.EventHandler(this.cmdCargarLocalidad_Click);
            // 
            // FrmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 206);
            this.Controls.Add(this.cmdCargarLocalidad);
            this.Controls.Add(this.lblIdentificacionLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.txtIdentificacionLocalidad);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmLocalidades";
            this.Text = "Localidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblIdentificacionLocalidad;
        private System.Windows.Forms.Button cmdCargarLocalidad;
        public System.Windows.Forms.TextBox txtIdentificacionLocalidad;
    }
}