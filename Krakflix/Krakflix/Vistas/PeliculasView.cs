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
    public partial class PeliculasView : Form
    {
        public PeliculasView()
        {
            InitializeComponent();
        }

        private void PeliculasView_ResizeEnd(object sender, EventArgs e)
        {
            var hola = Height;
            var position = Location;
            

            MessageBox.Show(position + "");
        }
    }
}
