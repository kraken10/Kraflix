﻿using Krakflix.Controlador;
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
        public ModUser(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string oldPass = txtPassOld.Text;
            string newPass = txtPassNew.Text;
            if (oldPass != newPass)
                if (userctr.cambiarPass(_user))
                    MessageBox.Show("Password cambiada con éxito","Éxito");
                else
                    MessageBox.Show("Error al cambiar la password", "Error");
            else
                MessageBox.Show("La password no puede ser igual a la anterior", "Error");
        }
    }
}
