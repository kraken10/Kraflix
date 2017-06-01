using Krakflix.Controlador;
using Krakflix.Controlador.Login;
using Krakflix.Modelo;
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
        private Principal princ;
        private Register register = new Register();
        public Login()
        {
            InitializeComponent();

        }

        private void btnloginClick(object sender, EventArgs e)
        {
            //el metodo verificar user nos devuelve el usuario logado
            User UserCorrecto = lgcontrol.verificarUser(txtUser.Text, TxtPass.Text);

            if (UserCorrecto != null)
            {
                //si el usuario es correcto se nos cierra esta ventana y se abre la ventana principal
                princ = new Principal(UserCorrecto);
                Hide();
                princ.Closed += (s, args) => this.Close();
                princ.Show();
            }
            else
                MessageBox.Show("Datos introducidos incorrectos", "Error");
        }
        //evento del link que abre la ventana de registro.
        private void linkRegister(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            register.Closed += (s, args) => this.Close();
            register.Show();
        }
    }
}
