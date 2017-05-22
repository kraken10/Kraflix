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

        public void cargarPeliculas(User user)
        {
            filmsRepo = new FilmRepository();
            string genre = cmbGenres.SelectedItem != null ? cmbGenres.SelectedItem.ToString() : string.Empty;
            int genreInt = getGenre(genre);
            var allFilms = filmsRepo.GetAll();
            var filmsById = filmsRepo.GetByUser(allFilms, genreInt, _user).ToList();

            listBoxPelis.Items.Clear();
            foreach (var film in filmsById)
            {
                listBoxPelis.Items.Add(film.Title);
            }

        }

        private void btnBuscarClick(object sender, EventArgs e)
        {
            cargarPeliculas(_user);
        }

        private void listBoxPelis_DoubleClick(object sender, EventArgs e)
        {
            filmSelected = listBoxPelis.SelectedItem.ToString();
            var allFilms = filmsRepo.GetAll();
            Film filmtoShow = filmsRepo.GetBytitle(allFilms, filmSelected).FirstOrDefault();
            showFilm(filmtoShow);
        }
        private void showFilm(Film film)
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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            var allFilms = filmsRepo.GetAll();
            Film filmtoPlay = filmsRepo.GetBytitle(allFilms, filmSelected).FirstOrDefault();
            Process.Start("wmplayer", filmtoPlay.Path);
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
