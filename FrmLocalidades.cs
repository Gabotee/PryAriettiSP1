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
    public partial class FrmLocalidades : Form
    {
        public FrmLocalidades()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdCargarLocalidad_Click(object sender, EventArgs e)
        {
            bool BanderaLocalidad = false;

            StreamWriter swLocalidades = new StreamWriter("./Localidades.text", true);

            swLocalidades.Close();

            StreamReader srLocalidades = new StreamReader("./Localidades.text");

            char VarSeparador = Convert.ToChar(" ");

            

            while (!srLocalidades.EndOfStream)
            {
                // string auxcodigo = srLocalidades.ReadLine();

                string[] VecIdentificadorLocalidad = srLocalidades.ReadLine().Split(VarSeparador);

                if (txtIdentificacionLocalidad.Text == VecIdentificadorLocalidad[0])
                {

                    MessageBox.Show("El Numero de identificacion ya existe, intente con otro");

                    BanderaLocalidad = true;

                    txtIdentificacionLocalidad.Focus();

                    txtLocalidad.Text = "";

                    txtIdentificacionLocalidad.Text = "";


                }

            }

            srLocalidades.Close();

            if (BanderaLocalidad == false)
            {

                //Crea un archivo 
                StreamWriter swGrabar = new StreamWriter("./Localidades.text", true);

                //Se le asigna lo q se escribio en el txt al archivo.
                swGrabar.WriteLine(txtIdentificacionLocalidad.Text + " " + txtLocalidad.Text);

                swGrabar.Close();

                MessageBox.Show("Se han cargado los datos corretamente");

                txtIdentificacionLocalidad.Focus();

                txtLocalidad.Text = "";

                txtIdentificacionLocalidad.Text = "";

                
            }

        }
    }
}
