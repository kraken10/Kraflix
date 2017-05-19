using Krakflix.Modelo;
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
        public Principal(User user)
        {
            InitializeComponent();
            _user = user;
        }
        public Principal()
        {
            InitializeComponent();
        }

        private void PlayerPeli_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)PlayerPeli.Ctlcontrols;
            controls.pause();
            lblVideoPeli.Visible = true;
        }

        private void Principal_MouseEnter(object sender, EventArgs e)
        {
            WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)PlayerPeli.Ctlcontrols;
            WMPLib.IWMPControls3 controls2 = (WMPLib.IWMPControls3)PlayerSerie.Ctlcontrols;
            controls.play();
            controls2.play();
            lblVideoPeli.Visible = false;
            lblVideoSerie.Visible = false;
        }

        private void PlayerSerie_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)PlayerSerie.Ctlcontrols;
            controls.pause();
            lblVideoSerie.Visible = true;
        }

        private void VideoPelisClick(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            PeliculasView pelis = new PeliculasView();
            //Close();
            pelis.Show();
        }

        private void lblVideoPelisClick(object sender, EventArgs e)
        {
            PeliculasView pelis = new PeliculasView();
            //Close();
            pelis.Show();
        }

        private void VideoSeriesClick(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            SeriesView series = new SeriesView();
            series.Show();
        }
    }
}
