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
    public partial class InicioSesión : Form
    {
        string UserAdmin = "AndresQuintero";
        string passwordAdmin = "andres123";
        string User_1 = "JuanitaPerez";
        string passwordUser_1 = "juanita123";
        string User_2 = "JuanCastillo";
        string passwordUser_2 = "juan123";


        public InicioSesión()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == UserAdmin && TxtContraseña.Text == passwordAdmin)
            {
                TxtUsuario.Clear();
                TxtContraseña.Clear();
            }

        }
    }
}
