using Krakflix.Controlador;
using Krakflix.Controlador.Repositorios;
using Krakflix.Modelo;
using Krakflix.Properties;
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
    public partial class PeliculasView : Form
    {
        private User _user;
        private GenreRepository genres;
        private FilmRepository filmsRepo;
        private static string filmSelected;

        public PeliculasView(User user)
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
                cmbGenres.Items.Add(name.Description);
            }
        }

        public void cargarPeliculas()
        {
            filmsRepo = new FilmRepository();
            string genre = cmbGenres.SelectedItem != null ? cmbGenres.SelectedItem.ToString() : string.Empty;
            int genreInt = getGenre(genre);
            var allFilms = filmsRepo.GetAll();
            var filmsById = filmsRepo.GetByUser(allFilms, genreInt, _user).ToList();

            listBoxPelis.Items.Clear();
            cmbGenres.Text = "Todas";
            foreach (var film in filmsById)
            {
                listBoxPelis.Items.Add(film.Title);
            }
        }

        private void btnBuscarClick(object sender, EventArgs e)
        {
            cargarPeliculas();
        }

        private void listBoxPelis_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                filmSelected = listBoxPelis.SelectedItem.ToString();
                var allFilms = filmsRepo.GetAll();
                Film filmtoShow = filmsRepo.GetBytitle(allFilms, filmSelected).FirstOrDefault();
                showFilm(filmtoShow);
            }
            catch (NullReferenceException)
            {

            }

        }

        private void showFilm(Film film)
        {
            try
            {
                lblTitulo.Text = "";
                lblDuration.Text = "";
                lblYear.Text = "";
                lblRate.Text = "";
                lblDescripcion.Text = "";

                lblTitulo.Text = "Título: " + film.Title;
                lblDuration.Text = "Duración: " + film.Duration + " min";
                lblYear.Text = "Año: " + film.Year;
                lblRate.Text = "Puntuación: " + film.Rate + "/10";
                lblDescripcion.Text = film.Description;
                imgPelicula.Image = Image.FromFile(film.PhotoPath);
            }
            catch (Exception)
            {
                var bmp = new Bitmap(Resources.NoPhoto);
                imgPelicula.Image = bmp;
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                var allFilms = filmsRepo.GetAll();
                Film filmtoPlay = filmsRepo.GetBytitle(allFilms, filmSelected).FirstOrDefault();
                if (filmtoPlay != null)
                {
                    if (filmtoPlay.Path.Contains("http"))
                    {
                        if (filmtoPlay.Path.Contains("youtube"))
                        {
                            VideoOnline v = new VideoOnline(filmtoPlay.Path);
                            v.Show();
                        }
                        else
                            Process.Start(filmtoPlay.Path);
                    }
                    else
                    {
                        Process.Start("wmplayer", filmtoPlay.Path);
                    }
                }
                else
                    MessageBox.Show("No se ha seleccionado ninguna película", "Error");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No se ha seleccionado ninguna pelicula", "Error al reproducir");
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

    }
}
