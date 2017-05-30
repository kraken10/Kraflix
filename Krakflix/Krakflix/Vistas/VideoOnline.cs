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
    public partial class VideoOnline : Form
    {
        private string _url = "";
        public VideoOnline(string url)
        {
            InitializeComponent();
            _url = url;
        }

        private void VideoOnline_Load(object sender, EventArgs e)
        {
            string videoUrl = _url.Replace("watch?v=", "v/");
            ShockwaveFlash.Movie = videoUrl;
            ShockwaveFlash.Play();
        }
    }
}
