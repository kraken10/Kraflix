using Krakflix.Controlador;
using Krakflix.Controlador.Login;
using Krakflix.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Krakflix
{
    public partial class Login : Form
    {

        private LoginController lgcontrol = new LoginController();
        private Principal princ = new Principal();
        private Register register = new Register();
        public Login()
        {
            InitializeComponent();

        }

        private void btnloginClick(object sender, EventArgs e)
        {
            bool correcto = lgcontrol.verificarUser(txtUser.Text, TxtPass.Text);

            if (correcto)
            {
                Hide();
                princ.Closed += (s, args) => this.Close();
                princ.Show();
            }
            else
                MessageBox.Show("Error", "Datos introducidos incorrectos");
        }

        private void linkRegister(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            register.Closed += (s, args) => this.Close();
            register.Show();
        }
    }
}
