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
    public partial class AddSerie : Form
    {
        User _user = new User();
        private GenreRepository genres = new GenreRepository();
        private SerieController serieController;
        private bool photo = false;
        private Serie serie;
        private string photoPath = "";
        public AddSerie(User user)
        {
            InitializeComponent();
            _user = user;
            cargarGenre();
        }
        private void cargarGenre()
        {
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
                serieController = new SerieController();
                serie = new Serie();
                serie.Title = txtTitle.Text.Trim();
                serie.NumTemp = string.IsNullOrEmpty(txtTemp.Text.Trim()) ? 0 : int.Parse(txtTemp.Text);
                serie.IdGenre = cmbGenres.SelectedItem == null ? -1 : getGenre(cmbGenres.SelectedItem.ToString());
                serie.Year = string.IsNullOrEmpty(txtYear.Text.Trim()) ? 0 : int.Parse(txtYear.Text);
                serie.Rate = string.IsNullOrEmpty(txtRate.Text.Trim()) ? 0 : int.Parse(txtRate.Text);
                serie.Description = txtDescription.Text.Trim();
                serie.PhotoPath = photo == true ? photoPath.ToString() : string.Empty;
                serie.IdUser = _user.IdUser;
                if (string.IsNullOrEmpty(serie.Title) || serie.NumTemp == 0 || serie.Year == 0 || serie.Rate == 0 || serie.IdGenre == -1
                    || string.IsNullOrEmpty(serie.Description))
                {
                    MessageBox.Show("Faltan campos por rellenar", "Error");
                }
                else
                {
                    if (serieController.crearSerie(serie) != true)
                    {
                        MessageBox.Show("Ha ocurrido un error al añadir la serie", "Error");
                    }
                    else
                    {
                        MessageBox.Show("Serie añadida", "Éxito");
                        txtTemp.Text = "";
                        txtTitle.Text = "";
                        txtRate.Text = "";
                        cmbGenres.Text = "Selecciona";
                        txtYear.Text = "";
                        txtDescription.Text = "";
                        imgSerie.Image = null;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campos Rellenados incorrectamente", "Error");
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

        private void imgSerie_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                photoPath = dialog.FileName;
                imgSerie.SizeMode = PictureBoxSizeMode.StretchImage;
                imgSerie.Image = Image.FromFile(photoPath);
                photo = true;
            }
        }
    }
}
