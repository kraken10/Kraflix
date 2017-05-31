﻿using Krakflix.Controlador;
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
    public partial class RemoveSerie : Form
    {
        private User _user = new User();
        private GenreRepository genres = new GenreRepository();
        private SerieRepository serieRepo = new SerieRepository();
        private SerieController seriectrl = new SerieController();
        public RemoveSerie(User user)
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
            cargarSeries();
        }

        private void listBoxSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serieSelected = listBoxSeries.SelectedItem.ToString();

            DialogResult result = MessageBox.Show("¿ Estas Seguro de borrar " + serieSelected + " ?",
                "Borrar", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (seriectrl.removeSerie(serieSelected) != false)
                {
                    MessageBox.Show("Serie Borrada correctamente", "Éxito");
                    cargarSeries();
                }

                else
                    MessageBox.Show("Error al borrar la serie", "Error");
            }

        }
        public void cargarSeries()
        {
            string genre = cmbGenres.SelectedItem != null ? cmbGenres.SelectedItem.ToString() : string.Empty;
            int genreInt = getGenre(genre);
            var allSeries = serieRepo.getAll();
            var seriesById = serieRepo.GetByUser(allSeries, genreInt, _user).ToList();

            listBoxSeries.Items.Clear();
            foreach (var film in seriesById)
            {
                listBoxSeries.Items.Add(film.Title);
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
