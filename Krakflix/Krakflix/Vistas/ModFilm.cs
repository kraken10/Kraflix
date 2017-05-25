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
    public partial class ModFilm : Form
    {
        private string photoPath = "";
        private string filmPath = "";
        private User _user = new User();
        private GenreRepository genres;
        private FilmController filmcontroller;
        private FilmRepository filmsRepo = new FilmRepository();
        private bool photo = false;
        private bool pathSelected = false;
        private Film film;
        public ModFilm(User user)
        {
            InitializeComponent();
            _user = user;
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
        private void cargarGenresMod()
        {
            genres = new GenreRepository();
            var genresList = genres.GetAll().ToList();

            foreach (var name in genresList)
            {
               cmbGenreMod.Items.Add(name.Description);
            }
        }
        private void imgPeli_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                photoPath = dialog.FileName;
                imgPeli.Image = Image.FromFile(photoPath);
                photo = true;
            }
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Video Files | *.avi *.mkv | All Files | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filmPath = dialog.FileName;
                pathSelected = true;
                lblCorrecto.Visible = true;
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            //para modificar habra que cambiar cosas
            try
            {
                filmcontroller = new FilmController();
                film = new Film();
                film.Title = txtTitle.Text.Trim();
                film.Duration = string.IsNullOrEmpty(txtDuration.Text.Trim()) ? 0 : int.Parse(txtDuration.Text);
                film.IdGenre = cmbGenres.SelectedItem == null ? -1 : getGenre(cmbGenres.SelectedItem.ToString());
                film.Year = string.IsNullOrEmpty(txtYear.Text.Trim()) ? 0 : int.Parse(txtYear.Text);
                film.Rate = string.IsNullOrEmpty(txtRate.Text.Trim()) ? 0 : int.Parse(txtRate.Text);
                film.Description = txtDescription.Text.Trim();
                film.PhotoPath = photo == true ? photoPath.ToString() : string.Empty;
                film.Path = filmPath;
                if (string.IsNullOrEmpty(film.Title) || film.Duration == 0 || film.Year == 0 || film.Rate == 0 || film.IdGenre == -1
                    || string.IsNullOrEmpty(film.Description))
                {
                    MessageBox.Show("Faltan campos por rellenar", "Error");
                }
                else
                {
                    if (filmcontroller.modificarPeli(film) != true)
                    {
                        MessageBox.Show("Ha ocurrido un error al modificar la pelicula", "Error");
                    }
                    else
                    {
                        MessageBox.Show("Película modificada", "Éxito");
                        txtDuration.Text = "";
                        txtTitle.Text = "";
                        txtRate.Text = "";
                        cmbGenres.Text = "Selecciona";
                        txtYear.Text = "";
                        lblCorrecto.Visible = false;
                    }
                }
            }
            catch (Exception q)
            {
                MessageBox.Show("Campos Rellenados incorrectamente" + q.Message, "Error");
            }
        }
        
        private void showFilm(Film film)
        {
            txtTitle.Text = "";
            txtDuration.Text = "";
            txtYear.Text = "";
            txtRate.Text = "";
            txtDescription.Text = "";

            txtTitle.Text = film.Title;
            txtDuration.Text = film.Duration.ToString();
            txtYear.Text = film.Year.ToString();
            cmbGenreMod.SelectedItem = getGenre(film.IdGenre);
            cmbGenreMod.Text = getGenre(film.IdGenre);
            txtRate.Text =  film.Rate.ToString();
            txtDescription.Text = film.Description;
            imgPeli.Image = Image.FromFile(film.PhotoPath);
        }
        public string getGenre(int genre)
        {
            switch (genre)
            {
                case 1:
                    return "Acción";
                case 2:
                    return "Terror";
                case 3:
                    return "Comedia";
                case 4:
                    return "Romántica";
                case 5:
                    return "Ciencia Ficción";
            }
            return "No asignado";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarPeliculas();
            cargarGenresMod();
        }
        public void cargarPeliculas()
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

        private void listBoxPelis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filmListBoxSelected = listBoxPelis.SelectedItem.ToString();
            var allFilms = filmsRepo.GetAll();
            Film filmtoShow = filmsRepo.GetBytitle(allFilms, filmListBoxSelected).FirstOrDefault();
            showFilm(filmtoShow);
        }
    }
}
