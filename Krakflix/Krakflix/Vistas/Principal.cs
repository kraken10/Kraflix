using Krakflix.Modelo;
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
    public partial class Principal : Form
    {
        private User _user;
        public Principal(User user)
        {
            InitializeComponent();
            _user = user;
        }
        public Principal()
        {
            InitializeComponent();
        }
        
}
