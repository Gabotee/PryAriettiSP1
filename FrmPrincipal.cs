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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalidades ObjLocalidades = new FrmLocalidades();
            ObjLocalidades.ShowDialog();
        }

        private void cultivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCultivo ObjCultivo = new FrmCultivo();
            ObjCultivo.ShowDialog();
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduccion ObjProduccion = new FrmProduccion();
            ObjProduccion.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
