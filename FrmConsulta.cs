using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryAriettiSP1
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            StreamReader SrLeer = new StreamReader("./Produccion.text");
            char VarSeparador = Convert.ToChar(" ");
            dgvConsultar.Rows.Clear();

            while (!SrLeer.EndOfStream)
            {
                string[] VecProduccion = SrLeer.ReadLine().Split(VarSeparador);

                dgvConsultar.Rows.Add(VecProduccion);
            }
            SrLeer.Close();
        }
    }
}
