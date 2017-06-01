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
        private FilmController filmcontroller = new FilmController();
        private FilmRepository filmsRepo = new FilmRepository();
        private bool photo = false;
        private bool pathSelected = false;
        private Film film;
        private static string filmListBoxSelected;
        public ModFilm(User user)
        {
            InitializeComponent();
            _user = user;
            cargarGenres();
        }
        private void cargarGenres()
        {
            //cargamos los generos en el combo
            genres = new GenreRepository();
            var genresList = genres.GetAll().ToList();

            foreach (var name in genresList)
            {
                cmbGenres.Items.Add(name.Description);
            }
        }
        private void cargarGenresMod()
        {
            //cargamos los generos en el combo
            genres = new GenreRepository();
            var genresList = genres.GetAll().ToList();

            foreach (var name in genresList)
            {
                cmbGenreMod.Items.Add(name.Description);
            }
        }
        private void imgPeli_Click(object sender, EventArgs e)
        {
            //abrimos un dialogo para que el usuario pueda indicar la ruta del archivo
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                photoPath = dialog.FileName;
                imgPeli.SizeMode = PictureBoxSizeMode.StretchImage;
                imgPeli.Image = Image.FromFile(photoPath);
                photo = true;
            }
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            //abrimos un dialogo para que el usuario pueda indicar la ruta del archivo
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Video Files | *.avi *.mkv | All Files | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filmPath = dialog.FileName;
                pathSelected = true;
                lblCorrecto.Visible = true;
            }
        }
        //metodo que devuelve el id del genero para hacer la query en BDD
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
            try
            {
                var allFilms = filmsRepo.GetAll();
                Film filmToedit = filmsRepo.GetBytitle(allFilms, filmListBoxSelected).FirstOrDefault();
                //recogemos la pelicula a modificar y vamos comparando si los datos introducidos son distintos a los que tiene.
                //en ese caso se los asignamos
                if (filmToedit.Title != txtTitle.Text)
                    filmToedit.Title = txtTitle.Text;
                if (filmToedit.Duration.ToString() != txtDuration.Text)
                    filmToedit.Duration = int.Parse(txtDuration.Text);
                if (filmToedit.IdGenre != getGenre(cmbGenreMod.SelectedItem.ToString()))
                    filmToedit.IdGenre = getGenre(cmbGenreMod.SelectedItem.ToString());
                if (filmToedit.Year.ToString() != txtYear.Text)
                    filmToedit.Year = int.Parse(txtYear.Text);
                if (pathSelected == true)
                    filmToedit.Path = filmPath;
                if (filmToedit.Description != txtDescription.Text)
                    filmToedit.Description = txtDescription.Text;
                if (photo == true)
                    filmToedit.PhotoPath = photoPath;
                if (!string.IsNullOrEmpty(txtUrl.Text))
                    filmToedit.Path = txtUrl.Text;
                
                //comprobamos campos vacios o incorrectos
                if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtDuration.Text) || string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(txtRate.Text) || getGenre(cmbGenreMod.SelectedItem.ToString()) == -1
                    || string.IsNullOrEmpty(txtDescription.Text))
                {
                    MessageBox.Show("Faltan campos por rellenar", "Error");
                }
                else
                {
                    //si todo ha ido bien llamamos al metodo para modificar
                    if (filmcontroller.modificarPeli(filmToedit) != true)
                    {
                        MessageBox.Show("Ha ocurrido un error al modificar la pelicula", "Error");
                    }
                    else
                    {
                        //reiniciamos campos y parametros
                        MessageBox.Show("Película modificada", "Éxito");
                        txtDuration.Text = "";
                        txtTitle.Text = "";
                        txtRate.Text = "";
                        cmbGenres.Text = "Selecciona";
                        txtYear.Text = "";
                        txtDescription.Text = "";
                        cmbGenreMod.Text = "Selecciona";
                        cmbGenres.Text = "Selecciona";
                        txtUrl.Text = "";
                        lblCorrecto.Visible = false;
                        listBoxPelis.Items.Clear();
                        imgPeli.Image = null;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campos Rellenados incorrectamente", "Error");
            }
        }

        //metodo que muestra en la vista los datos de la pelicula
        private void showFilm(Film film)
        {
            txtTitle.Text = "";
            txtDuration.Text = "";
            txtYear.Text = "";
            txtRate.Text = "";
            txtDescription.Text = "";
            txtUrl.Text = "";

            txtTitle.Text = film.Title;
            txtDuration.Text = film.Duration.ToString();
            txtYear.Text = film.Year.ToString();
            cmbGenreMod.SelectedItem = getGenre(film.IdGenre);
            cmbGenreMod.Text = getGenre(film.IdGenre);
            txtRate.Text = film.Rate.ToString();
            txtDescription.Text = film.Description;
            if (film.Path.Contains("http") || film.Path.Contains("www"))
                txtUrl.Text = film.Path;
            try
            {
                imgPeli.Image = Image.FromFile(film.PhotoPath);
            }
            catch (Exception)
            {

            }
            
        }
        //metodo que devuelve el id del genero para hacer la query en BDD
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
            //muestra las peliculas en el listBox
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
            //lanza la query con la pelicula seleccionada en el listbox para mostrarla en la vista
            try
            {
                filmListBoxSelected = listBoxPelis.SelectedItem.ToString();
                var allFilms = filmsRepo.GetAll();
                Film filmtoShow = filmsRepo.GetBytitle(allFilms, filmListBoxSelected).FirstOrDefault();
                showFilm(filmtoShow);
            }
            catch (Exception) {}
            
        }
        
    }
}
