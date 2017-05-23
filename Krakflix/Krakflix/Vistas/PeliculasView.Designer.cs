using System.Windows.Forms;

namespace Krakflix.Vistas
{
    partial class PeliculasView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeliculasView));
            this.imgPelicula = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbGenres = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.listBoxPelis = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTituloDescripcion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPelicula
            // 
            this.imgPelicula.Location = new System.Drawing.Point(625, 72);
            this.imgPelicula.Name = "imgPelicula";
            this.imgPelicula.Size = new System.Drawing.Size(250, 223);
            this.imgPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPelicula.TabIndex = 0;
            this.imgPelicula.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTitulo.Location = new System.Drawing.Point(898, 88);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(79, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título: ";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblDuration.Location = new System.Drawing.Point(898, 140);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(80, 21);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duración: ";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblRate.Location = new System.Drawing.Point(898, 229);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(95, 21);
            this.lblRate.TabIndex = 3;
            this.lblRate.Text = "Puntuación: ";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblYear.Location = new System.Drawing.Point(898, 187);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(45, 21);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Año: ";
            // 
            // cmbGenres
            // 
            this.cmbGenres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbGenres.FormattingEnabled = true;
            this.cmbGenres.Location = new System.Drawing.Point(92, 78);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(177, 29);
            this.cmbGenres.TabIndex = 6;
            this.cmbGenres.TabStop = false;
            this.cmbGenres.Text = "Todos";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblGenre.Location = new System.Drawing.Point(12, 81);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(61, 21);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "Género";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(1219, 133);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(111, 75);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = " Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // listBoxPelis
            // 
            this.listBoxPelis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxPelis.FormattingEnabled = true;
            this.listBoxPelis.ItemHeight = 21;
            this.listBoxPelis.Location = new System.Drawing.Point(67, 153);
            this.listBoxPelis.Name = "listBoxPelis";
            this.listBoxPelis.Size = new System.Drawing.Size(253, 340);
            this.listBoxPelis.TabIndex = 11;
            this.listBoxPelis.SelectedIndexChanged += new System.EventHandler(this.listBoxPelis_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(299, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarClick);
            // 
            // lblTituloDescripcion
            // 
            this.lblTituloDescripcion.AutoSize = true;
            this.lblTituloDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloDescripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTituloDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTituloDescripcion.Location = new System.Drawing.Point(620, 298);
            this.lblTituloDescripcion.Name = "lblTituloDescripcion";
            this.lblTituloDescripcion.Size = new System.Drawing.Size(124, 30);
            this.lblTituloDescripcion.TabIndex = 13;
            this.lblTituloDescripcion.Text = "Descripción";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblDescripcion.Location = new System.Drawing.Point(621, 354);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(0, 21);
            this.lblDescripcion.TabIndex = 14;
            // 
            // PeliculasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Krakflix.Properties.Resources.backk;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTituloDescripcion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.listBoxPelis);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cmbGenres);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.imgPelicula);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(237, 13);
            this.Name = "PeliculasView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peliculas";
            ((System.ComponentModel.ISupportInitialize)(this.imgPelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPelicula;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbGenres;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListBox listBoxPelis;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTituloDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}