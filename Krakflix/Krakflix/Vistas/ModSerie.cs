using Krakflix.Controlador;
using Krakflix.Controlador.Repositorios;
using Krakflix.Modelo;
using Krakflix.Properties;
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
        private SerieRepository serieRepo = new SerieRepository();
        private SerieController serieCtr = new SerieController();
        private static Serie serietoShow;
        private static string photoPath = "";
        private static string serieSelected = "";
        private bool photo = false;
        private bool pathSelected = false;
        public ModSerie(User user)
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
                cmbGenreMod.Items.Add(name.Description);
            }
        }
        private void btnCapitulos_Click(object sender, EventArgs e)
        {
            //muestra la ventana de editar capitulos
            ModCapitulos modCap = new ModCapitulos(serietoShow);
            modCap.Show();
        }

        private void imgPeli_Click(object sender, EventArgs e)
        {
            //abrimos un dialogo para que el usuario pueda indicar la ruta del archivo
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                photoPath = dialog.FileName;
                imgSerie.Image = Image.FromFile(photoPath);
                photo = true;
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
        //metodo que devuelve el nombre del genero para hacer la query en BDD
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
            return "";
        }
        
        public void cargarSeries(User user)
        {
            //metodo que carga las series en el listbox
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
            //cuando una serie es seleccionada en el listbox se muestra en la vista
            serieSelected = listBoxSeries.SelectedItem.ToString();
            var allSeries = serieRepo.getAll();
            serietoShow = serieRepo.GetBytitle(allSeries, serieSelected).FirstOrDefault();
            //metodo que muestra la serie en la vista
            showSerie(serietoShow);
            btnCapitulosMod.Enabled = true;
            btnAddChap.Enabled = true;
            
        }
        private void showSerie(Serie serie)
        {
            txtTitle.Text = "";
            txtTemporadas.Text = "";
            txtYear.Text = "";
            txtRate.Text = "";
            txtDescription.Text = "";
            txtTitle.Text = serie.Title;
            txtTemporadas.Text =  serie.NumTemp.ToString();
            cmbGenreMod.Text = getGenre(serie.IdGenre);
            txtYear.Text = serie.Year.ToString();
            txtRate.Text = serie.Rate.ToString();
            txtDescription.Text = serie.Description;
            if(serie.PhotoPath == "")
            {
                var bitmap = new Bitmap(Resources.NoPhoto);
                imgSerie.Image = bitmap;
            }else
                imgSerie.Image = Image.FromFile(serie.PhotoPath);

            serieSelected = serie.IdSerie;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                var allSeries = serieRepo.getAll();
                Serie serieToedit = serieRepo.GetById(allSeries, serieSelected).FirstOrDefault();
                //recogemos la serie a modificar y vamos comparando si los datos introducidos son distintos a los que tiene.
                //en ese caso se los asignamos
                if (serieToedit.Title != txtTitle.Text)
                    serieToedit.Title = txtTitle.Text;
                if (serieToedit.NumTemp.ToString() != txtTemporadas.Text)
                    serieToedit.NumTemp = int.Parse(txtTemporadas.Text);
                if (serieToedit.IdGenre != getGenre(cmbGenreMod.SelectedItem.ToString()))
                    serieToedit.IdGenre = getGenre(cmbGenreMod.SelectedItem.ToString());
                if (serieToedit.Year.ToString() != txtYear.Text)
                    serieToedit.Year = int.Parse(txtYear.Text);
                if (serieToedit.Description != txtDescription.Text)
                    serieToedit.Description = txtDescription.Text;
                if (photo == true)
                    serieToedit.PhotoPath = photoPath;
                //comprobamos campos
                if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtTemporadas.Text) || string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(txtRate.Text) || getGenre(cmbGenreMod.SelectedItem.ToString()) == -1
                    || string.IsNullOrEmpty(txtDescription.Text))
                {
                    MessageBox.Show("Faltan campos por rellenar", "Error");
                }
                else
                {
                    //si todo ha salido bien llamamos al metodo para modificar
                    if (serieCtr.modificarSerie(serieToedit) != true)
                    {
                        MessageBox.Show("Ha ocurrido un error al modificar la serie", "Error");
                    }
                    else
                    {
                        //reiniciamos campos y valores.
                        MessageBox.Show("Serie modificada", "Éxito");
                        txtTemporadas.Text = "";
                        txtTitle.Text = "";
                        txtRate.Text = "";
                        cmbGenres.Text = "Selecciona";
                        txtYear.Text = "";
                        txtDescription.Text = "";
                        cmbGenreMod.Text = "Selecciona";
                        imgSerie.Image = null;
                        listBoxSeries.Items.Clear();
                    }
                }
            }
            catch (Exception q)
            {
                MessageBox.Show("Campos Rellenados incorrectamente" + q.Message, "Error");
            }
        }
        
        private void btnAddChap_Click_1(object sender, EventArgs e)
        {
            //mostramos la vista de añadir capitulo
            AddChapter addChapter = new AddChapter(serieSelected);
            addChapter.Show();
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //carga las series en el listBox al pulsar el boton de buscar.
            cargarSeries(_user);
        }
    }
}
