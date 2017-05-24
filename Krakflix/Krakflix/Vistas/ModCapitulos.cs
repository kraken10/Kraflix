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
    public partial class ModCapitulos : Form
    {
        private string _serieTitle = "";
        public ModCapitulos(string serieTitle)
        {
            InitializeComponent();
            serieTitle = _serieTitle;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnRuta_Click(object sender, EventArgs e)
        {

        }
    }
}
