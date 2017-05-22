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
    public partial class ModFilm : Form
    {
        private User _user;
        public ModFilm(User user)
        {
            InitializeComponent();
            _user = user;
        }
    }
}
