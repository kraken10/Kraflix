using Krakflix.Controlador;
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
    public partial class AddFilm : Form
    {
        private string photoPath = "";
        private string filmPath = "";
        private User _user = new User();
        private GenreRepository genres = new GenreRepository();
        private FilmController filmcontroller;
        private bool photo = false;
        private bool pathSelected = false;
        private Film film;
        public AddFilm(User user)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
                if (!string.IsNullOrEmpty(txtUrl.Text))
                    film.Path = txtUrl.Text;
                film.IdUser = _user.IdUser;
                if (string.IsNullOrEmpty(film.Title) || film.Duration == 0 || film.Year == 0 || film.Rate == 0 || film.IdGenre == -1
                    || string.IsNullOrEmpty(film.Description) || (pathSelected == false && string.IsNullOrEmpty(txtUrl.Text)))
                {
                    MessageBox.Show("Faltan campos por rellenar", "Error");
                }
                else
                {
                    if (filmcontroller.agregarPeli(film) != true)
                    {
                        MessageBox.Show("Ha ocurrido un error al añadir la pelicula", "Error");
                    }
                    else
                    {
                        MessageBox.Show("Película añadida", "Éxito");
                        txtDuration.Text = "";
                        txtTitle.Text = "";
                        txtRate.Text = "";
                        cmbGenres.Text = "Selecciona";
                        txtYear.Text = "";
                        txtDescription.Text = "";
                        txtUrl.Text = "";
                        lblCorrecto.Visible = false;
                        imgPeli.Image = null;
                    }
                }
            }catch(Exception)
            {
                MessageBox.Show("Campos Rellenados incorrectamente", "Error");
            }
            
        }

        private void imgPeli_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                photoPath = dialog.FileName;
                imgPeli.SizeMode = PictureBoxSizeMode.StretchImage;
                imgPeli.Image = Image.FromFile(photoPath);
                photo = true;
                
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
        
    }
}
