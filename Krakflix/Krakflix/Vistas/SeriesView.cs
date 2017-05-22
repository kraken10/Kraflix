using Krakflix.Controlador;
using Krakflix.Controlador.Repositorios;
using Krakflix.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Krakflix.Vistas
{
    public partial class SeriesView : Form
    {
        private User _user;
        private GenreRepository genres;
        private SerieRepository serieRepo;
        private ChapterRepository chapterRepo = new ChapterRepository();
        private static string serieSelected;

        public SeriesView(User user)
        {
            InitializeComponent();
            _user = user;
            CargarGenres();
        }
        public void CargarGenres()
        {
            genres = new GenreRepository();
            var genresList = genres.GetAll().ToList();

            foreach (var name in genresList)
            {
                cmbGenresSerie.Items.Add(name.Description);
            }
        }

        public void cargarSeries(User user)
        {
            serieRepo = new SerieRepository();
            string genre = cmbGenresSerie.SelectedItem != null ? cmbGenresSerie.SelectedItem.ToString() : string.Empty;
            int genreInt = getGenre(genre);
            var allSeries= serieRepo.getAll();
            var SerieById = serieRepo.GetByUser(allSeries, genreInt, _user).ToList();

            listBoxSeries.Items.Clear();
            foreach (var serie in SerieById)
            {
                listBoxSeries.Items.Add(serie.Title);
            }

        }

        private void btnBuscarSerieClick(object sender, EventArgs e)
        {
            cargarSeries(_user);
        }

        private void listBoxSeries_DoubleClick(object sender, EventArgs e)
        {
            serieSelected = listBoxSeries.SelectedItem.ToString();
            var allSeries = serieRepo.getAll();
            Serie serietoShow = serieRepo.GetBytitle(allSeries, serieSelected).FirstOrDefault();
            showSerie(serietoShow);
        }
        private void showSerie(Serie serie)
        {
            lblTituloSerie.Text = "";
            lblTemporadasSerie.Text = "";
            lblYearSerie.Text = "";
            lblRateSerie.Text = "";
            lblDescripcionSerie.Text = "";
            lblTituloSerie.Text = "Título: " + serie.Title;
            lblTemporadasSerie.Text = "Temporadas: " + serie.NumTemp;
            lblYearSerie.Text = "Año: " + serie.Year;
            lblRateSerie.Text = "Puntuación: " + serie.Rate + "/10";
            lblDescripcionSerie.Text = serie.Description;
            imgSerie.Image = Image.FromFile(serie.PhotoPath);
            cmbTemp.Items.Clear();
            for (int i = 0; i < serie.NumTemp; i++)
            {
                cmbTemp.Items.Add(i+1);
            }
            serie.IdSerie = serieSelected;
        }
        private void cargarCap(string idSerie, int temp)
        {
            var allChapters = chapterRepo.getAll();
            List<Chapter> chapterbyId = chapterRepo.getById(allChapters, idSerie, temp).ToList();
            cmbCaps.Items.Clear();
            foreach (var chapter in chapterbyId)
            {
                cmbCaps.Items.Add(chapter);//aqui seria chapter.Name pero hay que añadirlo a la base de datos
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            var allchapter = chapterRepo.getAll();
            int tempSelected = (int)cmbTemp.SelectedItem;
            Chapter chapterToPlay = chapterRepo.getChapterToPlay(allchapter, serieSelected, tempSelected).FirstOrDefault();
            if (chapterToPlay != null)
                Process.Start("wmplayer", chapterToPlay.Path);
            else
                MessageBox.Show("No has seleccionado un capítulo", "Error");
        }
        public int getGenre(string genre)
        {
            switch (genre)
            {
                case "Acción":
                    return 1;
                case "Terror":
                    return 2;
                case "Comedia":
                    return 3;
                case "Romántica":
                    return 4;
                case "Ciencia Ficción":
                    return 5;
            }
            return -1;
        }

        private void cmbTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tempSelected = (int)cmbTemp.SelectedItem;
            cargarCap(serieSelected, tempSelected);
        }
    }
}
