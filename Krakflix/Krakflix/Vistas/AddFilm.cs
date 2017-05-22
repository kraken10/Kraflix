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
    public partial class AddFilm : Form
    {
        private User _user = new User();
        public AddFilm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
