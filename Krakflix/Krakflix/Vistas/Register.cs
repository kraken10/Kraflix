using Krakflix.Controlador.Registrer;
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
    public partial class Register : Form
    {
        private RegisterController reg = new RegisterController();
        
        static string photoPath = "";
        public Register()
        {
            InitializeComponent();
        }

        private void photoClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                photoPath = dialog.FileName;
                PhotoUser.SizeMode = PictureBoxSizeMode.StretchImage;
                PhotoUser.Image = Image.FromFile(photoPath);
            }

        }

        private void btnRegistro(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            string pass2 = txtPass2.Text.Trim();
            if (user != string.Empty && pass != string.Empty)
            {
                if (pass == pass2)
                {
                    if (reg.registerUser(user, pass, photoPath))
                    {
                        MessageBox.Show("Usuario registrado correctamente", "Éxito");
                        Hide();
                        Login login = new Login();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no Registrado", "Error");
                    }

                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error");
                }

            }
            else
            {
                MessageBox.Show("Faltan campos por rellenar");
            }
            
        }
        
    }
}
