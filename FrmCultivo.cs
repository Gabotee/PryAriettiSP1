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
    public partial class FrmCultivo : Form
    {
        public FrmCultivo()
        {
            InitializeComponent();
        }

        private void FrmCultivo_Load(object sender, EventArgs e)
        {

        }

        private void cmdCargraCultivo_Click(object sender, EventArgs e)
        {
            bool BanderaCultivo = false;

            //Crea un archivo 
            StreamWriter swCultivos = new StreamWriter("./Cultivos.text", true);

            swCultivos.Close();

            StreamReader srCultivos = new StreamReader("./Cultivos.text");

            char VarSeparador = Convert.ToChar(",");

            while (!srCultivos.EndOfStream)
            {
                string[] VecIndentificadorCultivo = srCultivos.ReadLine().Split(VarSeparador);

                if (txtIdentificacionCultivo.Text == VecIndentificadorCultivo[0])
                {
                    MessageBox.Show("El Numero de identificacion ya se encuentra registrado, Intente con otro");
                    BanderaCultivo = true;
                    txtIdentificacionCultivo.Text = "";
                    txtIdentificacionCultivo.Focus();
                }
            }

            srCultivos.Close();

            if (BanderaCultivo == false)
            {
                StreamWriter swGrabar = new StreamWriter("./Cultivos.text", true);

                //Se le asigna lo q se escribio en el txt al archivo.
                swGrabar.WriteLine(txtIdentificacionCultivo.Text + " " + txtCultivos.Text);

                swGrabar.Close();

                MessageBox.Show("Se Han Cargado Los Datos Correctamente");

                //Limpia los controles 
                txtCultivos.Text = "";

                txtIdentificacionCultivo.Text = "";

                txtIdentificacionCultivo.Focus();
            }
            
        }
    }
}
