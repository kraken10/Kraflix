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
        private static bool pathSelected = false;
        private static string chapterPath = "";

        public ModCapitulos(Serie serie)
        {
            InitializeComponent();
            serie = _serie;
            CargaTemp();
        }
        private void CargaTemp()
        {
            var allChapters = chapRepo.getAll();
            int numTemps= chapRepo.getTemps(allChapters, _serie);
            for (int i = 0; i < numTemps; i++)
            {
                cmbTemp.Items.Add(i+1);
                cmbTempMod.Items.Add(i+1);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {

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
            foreach (var chap in chapterBytemp)
            {
                cmbCap.Items.Add(chap.NombreCap);
            }
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
            string capSelected = cmbCap.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("¿ Estas Seguro de borrar " + capSelected + " ?",
                "Borrar", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (chapCtr.removeChapter(capSelected) != false)
                {
                    MessageBox.Show("Capítulo borrado correctamente", "Éxito");
                    txtTitle.Text = "";
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
    }
}
