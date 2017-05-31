using Krakflix.Controlador;
using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Krakflix.Vistas
{
    public partial class ModUser : Form
    {
        private UserController userctr = new UserController();
        private User _user;
        private UserRepository userRepo = new UserRepository();
        public ModUser(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string oldPass = txtPassOld.Text;
            string newPass = txtPassNew.Text;
            User UserToModify = userRepo.GetbyId(_user.IdUser).SingleOrDefault();
            UserToModify.Password = newPass;
            if (oldPass != newPass && oldPass == _user.Password)
                if (userctr.cambiarPass(UserToModify))
                {
                    MessageBox.Show("Password cambiada con éxito", "Éxito");
                    Close();
                }
                else
                    MessageBox.Show("Error al cambiar la password", "Error");
            else
                MessageBox.Show("Error al introducir la password", "Error");
        }
    }
}
