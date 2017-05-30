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
        private Serie _serie = new Serie();
        private ChapterController chapCtr = new ChapterController();
        private SerieRepository serieRepo = new SerieRepository();
        private ChapterRepository chapRepo = new ChapterRepository();
        private static bool pathSelected = false;
        private static string chapterPath = "";

        public ModCapitulos(Serie serie)
        {
            InitializeComponent();
            _serie = serie;
            CargaTemp();
        }
        private void CargaTemp()
        {
            var allseries = serieRepo.getAll();
            int serieTemp = serieRepo.getTempsById(allseries, _serie.IdSerie);
            cmbTemp.Items.Clear();
            for (int i = 0; i < serieTemp; i++)
            {
                cmbTemp.Items.Add(i + 1);
                cmbTempMod.Items.Add(i + 1);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var allChapters = chapRepo.getAll();
                Chapter chapterToEdit = chapRepo.getByTitle(allChapters, cmbCap.SelectedItem.ToString()).FirstOrDefault();
                if (txtTitle.Text != chapterToEdit.NombreCap)
                    chapterToEdit.NombreCap = txtTitle.Text;
                if (int.Parse(cmbTempMod.SelectedItem.ToString()) != chapterToEdit.Temp)
                    chapterToEdit.Temp = int.Parse(cmbTempMod.SelectedItem.ToString());
                if (pathSelected && string.IsNullOrEmpty(txtUrl.Text))
                    chapterToEdit.Path = chapterPath;
                if (!string.IsNullOrEmpty(txtUrl.Text))
                    chapterToEdit.Path = txtUrl.Text;


                if (string.IsNullOrEmpty(txtTitle.Text))
                    MessageBox.Show("Faltan campos por rellenar", "Error");
                else
                {
                    if (!chapCtr.modififyChapter(chapterToEdit))
                        MessageBox.Show("Ha ocurrido un error al modificar el capítulo", "Error");
                    else
                    {
                        txtTitle.Text = "";
                        cmbTempMod.Text = "Selecciona";
                        cmbCap.Text = "Selecciona";
                        cmbCap.Items.Clear();
                        cmbTemp.Text = "Selecciona";
                        txtUrl.Text = "";
                        MessageBox.Show("Capítulo modificado con éxito", "Éxito");
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado capítulo", "Error");
            }


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

        private void cmbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tempSelected = int.Parse(cmbTemp.SelectedItem.ToString());
            var allChapters = chapRepo.getAll();
            var chapterBytemp = chapRepo.getById(allChapters, _serie.IdSerie, tempSelected).ToList();
            cmbCap.Items.Clear();
            cmbCap.Text = "Selecciona";
            cmbTempMod.Text = "Selecciona";
            foreach (var chap in chapterBytemp)
            {
                cmbCap.Items.Add(chap.NombreCap);
            }
            txtTitle.Text = "";
        }

        private void cmbCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string capSelected = cmbCap.SelectedItem.ToString();
            int tempSelected = int.Parse(cmbTemp.SelectedItem.ToString());
            txtTitle.Text = capSelected;
            cmbTempMod.Text = tempSelected.ToString();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                string capSelected = cmbCap.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("¿ Estas Seguro de borrar " + capSelected + " ?",
                    "Borrar", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (chapCtr.removeChapter(capSelected) != false)
                    {
                        MessageBox.Show("Capítulo borrado correctamente", "Éxito");
                        txtTitle.Text = "";
                        cmbTempMod.Text = "Selecciona";
                        cmbCap.Text = "Selecciona";
                        cmbTemp.Text = "Selecciona";
                        txtUrl.Text = "";
                        int tempSelected = int.Parse(cmbTemp.SelectedItem.ToString());
                        var allChapters = chapRepo.getAll();
                        var chapterBytemp = chapRepo.getById(allChapters, _serie.IdSerie, tempSelected).ToList();
                        foreach (var chap in chapterBytemp)
                        {
                            cmbCap.Items.Add(chap.NombreCap);
                        }
                    }
                    else
                        MessageBox.Show("Error al borrar el capítulo", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado capitulo", "Error");
            }

        }
    }
}
