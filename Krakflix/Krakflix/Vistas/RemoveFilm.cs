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
    public partial class RemoveFilm : Form
    {
        private User _user = new User();
        private GenreRepository genres = new GenreRepository();
        private FilmController filmctr = new FilmController();
        private FilmRepository filmsRepo = new FilmRepository();
        public RemoveFilm(User user)
        {
            InitializeComponent();
            _user = user;
            cargarGenre();
        }

        private void cargarGenre()
        {
            genres = new GenreRepository();
            var genresList = genres.GetAll().ToList();

            foreach (var name in genresList)
            {
                cmbGenres.Items.Add(name.Description);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarPeliculas();
        }

        private void listBoxPelis_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filmSelected = listBoxPelis.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("¿ Estas Seguro de borrar " + filmSelected + " ?",
                    "Borrar", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (filmctr.borrarPeli(filmSelected) != false)
                    {
                        MessageBox.Show("Película Borrada correctamente", "Éxito");
                        listBoxPelis.Items.Clear();
                    }


                    else
                        MessageBox.Show("Error al borrar la película", "Error");
                }
            }
            catch (Exception)
            {
            }


        }
        public void cargarPeliculas()
        {

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
