namespace PryAriettiSP1
{
    partial class FrmConsulta
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
            this.dgvConsultar = new System.Windows.Forms.DataGridView();
            this.ColumnaLocalidadID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCultivoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaToneladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmdConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultar
            // 
            this.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaLocalidadID,
            this.ColumnaCultivoID,
            this.ColumnaToneladas});
            this.dgvConsultar.Location = new System.Drawing.Point(12, 38);
            this.dgvConsultar.Name = "dgvConsultar";
            this.dgvConsultar.ReadOnly = true;
            this.dgvConsultar.Size = new System.Drawing.Size(344, 201);
            this.dgvConsultar.TabIndex = 0;
            // 
            // ColumnaLocalidadID
            // 
            this.ColumnaLocalidadID.HeaderText = "Localidad ID";
            this.ColumnaLocalidadID.Name = "ColumnaLocalidadID";
            this.ColumnaLocalidadID.ReadOnly = true;
            // 
            // ColumnaCultivoID
            // 
            this.ColumnaCultivoID.HeaderText = "Cultivo ID";
            this.ColumnaCultivoID.Name = "ColumnaCultivoID";
            this.ColumnaCultivoID.ReadOnly = true;
            // 
            // ColumnaToneladas
            // 
            this.ColumnaToneladas.HeaderText = "Toneladas ";
            this.ColumnaToneladas.Name = "ColumnaToneladas";
            this.ColumnaToneladas.ReadOnly = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(104, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Informacion";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(281, 255);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 2;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 283);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvConsultar);
            this.Name = "FrmConsulta";
            this.Text = "FrmConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaLocalidadID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCultivoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaToneladas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button cmdConsultar;
    }
}