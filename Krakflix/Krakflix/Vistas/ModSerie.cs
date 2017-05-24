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
    public partial class ModSerie : Form
    {
        private User _user;
        private GenreRepository genres = new GenreRepository();
        private SerieRepository serieRepo;
        private static string photoPath = "";
        private static string serieSelected = "";
        public ModSerie(User user)
        {
            InitializeComponent();
            user = _user;
            cargarGenres();
        }
        private void cargarGenres()
        {
            genres = new GenreRepository();
            var genresList = genres.GetAll().ToList();

            foreach (var name in genresList)
            {
                cmbGenres.Items.Add(name.Description);
            }
        }
        private void btnCapitulos_Click(object sender, EventArgs e)
        {
            ModCapitulos modCap = new ModCapitulos();
            if(serieSelected!="")
                modCap.Show(serieSelected);
        }

        private void imgPeli_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                photoPath = dialog.FileName;
                imgSerie.Image = Image.FromFile(photoPath);
            }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarSeries(_user);
        }
        public void cargarSeries(User user)
        {
            serieRepo = new SerieRepository();
            string genre = cmbGenres.SelectedItem != null ? cmbGenres.SelectedItem.ToString() : string.Empty;
            int genreInt = getGenre(genre);
            var allSeries = serieRepo.getAll();
            var SerieById = serieRepo.GetByUser(allSeries, genreInt, _user).ToList();

            listBoxSeries.Items.Clear();
            foreach (var serie in SerieById)
            {
                listBoxSeries.Items.Add(serie.Title);
            }

        }
        private void listBoxSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            serieSelected = listBoxSeries.SelectedItem.ToString();
            var allSeries = serieRepo.getAll();
            Serie serietoShow = serieRepo.GetBytitle(allSeries, serieSelected).FirstOrDefault();
            showSerie(serietoShow);
        }
        private void showSerie(Serie serie)
        {
            txtTitle.Text = "";
            txtTemporadas.Text = "";
            txtYear.Text = "";
            txtRate.Text = "";
            txtDescription.Text = "";
            txtTitle.Text = "Título: " + serie.Title;
            txtTemporadas.Text = "Temporadas: " + serie.NumTemp;
            txtYear.Text = "Año: " + serie.Year;
            txtRate.Text = "Puntuación: " + serie.Rate + "/10";
            txtDescription.Text = serie.Description;
            imgSerie.Image = Image.FromFile(serie.PhotoPath);
            serieSelected = serie.IdSerie;
        }
    }
}
