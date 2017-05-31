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
    public partial class AddChapter : Form
    {
        private string _serieId = "";
        private SerieRepository serieRepo = new SerieRepository();
        private ChapterController chapterCtrl = new ChapterController();
        private string chapterPath = "";
        private bool pathSelected = false;
        private Chapter chapter;
        public AddChapter(string serieId)
        {
            InitializeComponent();
            _serieId = serieId;
            cargartemp();
        }
        private void cargartemp()
        {
            var allSeries = serieRepo.getAll();
            int tempBytitle = serieRepo.getTempsById(allSeries, _serieId);
            cmbTemp.Items.Clear();
            for (int i = 0; i < tempBytitle; i++)
            {
                cmbTemp.Items.Add(i+1);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            chapter = new Chapter();
            chapter.IdSerie = _serieId;
            chapter.Temp = cmbTemp.SelectedItem == null ? 0 : int.Parse(cmbTemp.SelectedItem.ToString());
            chapter.NombreCap = txtTitle.Text.Trim();
            chapter.Path = chapterPath;
            if (chapter.Temp != 0 || !string.IsNullOrEmpty(txtTitle.Text) || pathSelected)
            {
                if (chapterCtrl.addChapter(chapter))
                {
                    cmbTemp.Text = "Selecciona";
                    cargartemp();
                    txtTitle.Text = "";
                    lblCorrecto.Visible = false;
                    pathSelected = false;
                    MessageBox.Show("Capítulo añadido con éxito", "Éxito");
                }
                else
                    MessageBox.Show("Se ha producido un error al añadir el capítulo","Error");
                    
            }
            else
                MessageBox.Show("Faltan datos por rellenar","Error");
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Video Files | *.avi *.mkv | All Files | *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                chapterPath = dialog.FileName;
                pathSelected = true;
                lblCorrecto.Visible = true;
            }
        }
    }
}
