using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Andres
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            rtbRegistro.Text = "datos del cliente \n" + "nombre: " + TxtNombre.Text + "\n" + "Cedula: " + txtCedula.Text + "\n" +  "Pan aliñado: " + TxtAliñado.Text + "\n" + " Pan no Aliñado: " + TxtNoAliñado.Text + "\n" + "Pan especial: " + TxtEspecial.Text + "\n" + "valor total de la venta: " + TxtValor.Text;

                
        }
    }
}
