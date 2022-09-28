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
    public partial class FrmProduccion : Form
    {
        public FrmProduccion()
        {
            InitializeComponent();
        }

        private void FrmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader srLocalidad = new StreamReader("./Localidades.text");

            char VarSeparador = Convert.ToChar(" ");

            while (!srLocalidad.EndOfStream)
            {

                //string InformacionLocalidad = srLocalidad.ReadLine();
                string[] VecLocalidad = srLocalidad.ReadLine().Split(VarSeparador);

                lstLocalidades.Items.Add(VecLocalidad[0]);

            }

            srLocalidad.Close();

            StreamReader srCultivo = new StreamReader("./Cultivos.text");

            while (!srCultivo.EndOfStream)
            {
                //string InformacionLCultivo = srCultivo.ReadLine();
                string[] VecCultivo = srCultivo.ReadLine().Split(VarSeparador);

                lstCultivo.Items.Add(VecCultivo[0]);
            }

            srCultivo.Close();

        }

        private void cmdCargarToneladas_Click(object sender, EventArgs e)
        {
            StreamWriter srToneladas = new StreamWriter("./Produccion.text", true);

            srToneladas.WriteLine(lstLocalidades.Text + " " + lstCultivo.Text + " " + txtToneladas.Text);

            MessageBox.Show("Se han Cargado los datos Correctamente");

            srToneladas.Close();

            txtToneladas.Text = "";

            lstLocalidades.SelectedIndex = -1;

            lstCultivo.SelectedIndex = -1;
        }
    }
}
