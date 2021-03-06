﻿using Krakflix.Controlador;
using Krakflix.Modelo;
using Krakflix.Properties;
using Krakflix.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Krakflix
{
    public partial class Principal : Form
    {
        private User _user;
        private UserController userctrl;
        public Principal(User user)
        {
            InitializeComponent();
            _user = user;
            mostrarUser(_user);
            PlayerSerie.settings.mute = true;
            PlayerPeli.settings.mute = true;
        }
        public Principal()
        {
            InitializeComponent();
        }

        private void PlayerPeli_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            //cuando el raton esta en el video el video se para y saldra un label para seleccionar 
            WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)PlayerPeli.Ctlcontrols;
            controls.pause();
            lblVideoPeli.Visible = true;
        }

        private void Principal_MouseEnter(object sender, EventArgs e)
        {
            //cuando se abre el form los dos videos se ponen en marcha
            try
            {
                WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)PlayerPeli.Ctlcontrols;
                WMPLib.IWMPControls3 controls2 = (WMPLib.IWMPControls3)PlayerSerie.Ctlcontrols;
                controls.play();
                controls2.play();
                lblVideoPeli.Visible = false;
                lblVideoSerie.Visible = false;
            }
            catch (Exception) { }
            
        }

        private void PlayerSerie_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            //cuando el raton esta en el video el video se para y saldra un label para seleccionar 
            WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)PlayerSerie.Ctlcontrols;
            controls.pause();
            lblVideoSerie.Visible = true;
        }

        private void VideoPelisClick(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            //evento que muestra la vista de peliculas
            PeliculasView pelis = new PeliculasView(_user);
            pelis.Show();
        }

        private void lblVideoPelisClick(object sender, EventArgs e)
        {
            //evento que muestra la vista de peliculas
            PeliculasView pelis = new PeliculasView(_user);
            pelis.Show();
        }

        private void VideoSeriesClick(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            //evento que muestra la vista de series
            SeriesView series = new SeriesView(_user);
            series.Show();
        }
        private void mostrarUser(User user)
        {
            lblWelcome.Text = "WELCOME " + _user.UserName.ToUpper();
            try
            {
                imgUser.Image = Image.FromFile(_user.photoPath);
            }
            catch (Exception)
            {
                imgUser.Image = Resources.defaultPhoto1;
            }

        }

        private void lblVideoSerie_Click(object sender, EventArgs e)
        {
            //evento que muestra la vista de series
            SeriesView series = new SeriesView(_user);
            series.Show();
        }

        private void lblAñadirPeli_Click(object sender, EventArgs e)
        {
            //evento que muestra la vista de añadir pelicula
            AddFilm addfilm = new AddFilm(_user);
            addfilm.Show();
        }

        private void lblModificarPeli_Click(object sender, EventArgs e)
        {
            //evento que muestra la vista de modificar pelicula
            ModFilm modifyFilm = new ModFilm(_user);
            modifyFilm.Show();
        }

        private void lblEliminarPeli_Click(object sender, EventArgs e)
        {
            //evento que muestra la vista de borrar pelicula
            RemoveFilm remFilm = new RemoveFilm(_user);
            remFilm.Show();
        }

        private void lblPass_Click(object sender, EventArgs e)
        {
            //evento que muestra la vista de modificar la pass
            ModUser userMod = new ModUser(_user);
            userMod.Show();
        }

        private void lblFoto_Click(object sender, EventArgs e)
        {
            userctrl = new UserController();
            //abrimos un dialogo para que el usuario pueda indicar la ruta del archivo
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _user.photoPath = dialog.FileName;
                if (userctrl.cambiarFoto(_user))
                {
                    MessageBox.Show("Foto cambiada con éxito", "Éxito");
                    imgUser.Image = Image.FromFile(_user.photoPath);
                }
                else
                    MessageBox.Show("Error al actualizar la foto", "Error");
            }
        }

        private void lblAñadirSerie_Click(object sender, EventArgs e)
        {
            //evento que muestra la vista de añadir serie
            AddSerie addSerie = new AddSerie(_user);
            addSerie.Show();
        }

        private void lblModificarSerie_Click(object sender, EventArgs e)
        {
            //evento que muestra la vista de modificar serie
            ModSerie modSerie = new ModSerie(_user);
            modSerie.Show();
        }

        private void lblEliminarSerie_Click(object sender, EventArgs e)
        {
            //evento que muestra la vista de borrar serie
            RemoveSerie remSerie = new RemoveSerie(_user);
            remSerie.Show();
        }
        
    }
}
