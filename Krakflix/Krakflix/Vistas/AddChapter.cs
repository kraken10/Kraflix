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
            //cuando tenemos el numero de temporadas rellenamos el comboBox
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
            //comprobamos los txtBox para insertar
            chapter.Temp = cmbTemp.SelectedItem == null ? 0 : int.Parse(cmbTemp.SelectedItem.ToString());
            chapter.NombreCap = txtTitle.Text.Trim();

            if (!pathSelected)
                chapter.Path = txtUrl.Text;
            else
                chapter.Path = chapterPath;
            
            if (chapter.Temp != 0 || !string.IsNullOrEmpty(txtTitle.Text) || pathSelected || !string.IsNullOrEmpty(txtUrl.Text))
            {
                //si todo es correcto se llama al metodo de agregar capitulo
                if (chapterCtrl.addChapter(chapter))
                {
                    //y reiniciamos parametros
                    cmbTemp.Text = "Selecciona";
                    cargartemp();
                    txtTitle.Text = "";
                    txtUrl.Text = "";
                    lblCorrecto.Visible = false;
                    pathSelected = false;
                    //mostramos al usuario un alert de que todo ha salido bien
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
            //abrimos un dialogo para que el usuario pueda indicar la ruta del archivo
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
