using Krakflix.Controlador;
using Krakflix.Controlador.Repositorios;
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
    public partial class ModCapitulos : Form
    {
        private Serie _serie;
        private ChapterController chapCtr = new ChapterController();
        private ChapterRepository chapRepo = new ChapterRepository();
        public ModCapitulos(Serie serie)
        {
            InitializeComponent();
            serie = _serie;
        }
        private void CargaTemp(string _serieTitle)
        {
            var allChapters = chapRepo.getAll();
            var Caps = chapRepo.getTemps(allChapters, _serie).ToList();
            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnRuta_Click(object sender, EventArgs e)
        {

        }
    }
}
