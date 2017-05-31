using System;
using System.Windows.Forms;

namespace Krakflix.Vistas
{
    partial class SeriesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeriesView));
            this.imgSerie = new System.Windows.Forms.PictureBox();
            this.lblTituloSerie = new System.Windows.Forms.Label();
            this.lblTemporadasSerie = new System.Windows.Forms.Label();
            this.lblRateSerie = new System.Windows.Forms.Label();
            this.lblYearSerie = new System.Windows.Forms.Label();
            this.cmbGenresSerie = new System.Windows.Forms.ComboBox();
            this.lblGenreSerie = new System.Windows.Forms.Label();
            this.btnPlaySerie = new System.Windows.Forms.Button();
            this.listBoxSeries = new System.Windows.Forms.ListBox();
            this.lblTituloSerieDescripcion = new System.Windows.Forms.Label();
            this.lblcap = new System.Windows.Forms.Label();
            this.cmbCaps = new System.Windows.Forms.ComboBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.cmbTemp = new System.Windows.Forms.ComboBox();
            this.lblDescripcionSerie = new System.Windows.Forms.Label();
            this.btnBuscarSerie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgSerie)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSerie
            // 
            this.imgSerie.BackgroundImage = global::Krakflix.Properties.Resources.NoPhoto;
            this.imgSerie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSerie.Location = new System.Drawing.Point(409, 78);
            this.imgSerie.Name = "imgSerie";
            this.imgSerie.Size = new System.Drawing.Size(352, 223);
            this.imgSerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSerie.TabIndex = 0;
            this.imgSerie.TabStop = false;
            // 
            // lblTituloSerie
            // 
            this.lblTituloSerie.AutoSize = true;
            this.lblTituloSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloSerie.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTituloSerie.Location = new System.Drawing.Point(784, 94);
            this.lblTituloSerie.Name = "lblTituloSerie";
            this.lblTituloSerie.Size = new System.Drawing.Size(79, 30);
            this.lblTituloSerie.TabIndex = 1;
            this.lblTituloSerie.Text = "Título: ";
            // 
            // lblTemporadasSerie
            // 
            this.lblTemporadasSerie.AutoSize = true;
            this.lblTemporadasSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblTemporadasSerie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemporadasSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTemporadasSerie.Location = new System.Drawing.Point(784, 146);
            this.lblTemporadasSerie.Name = "lblTemporadasSerie";
            this.lblTemporadasSerie.Size = new System.Drawing.Size(101, 21);
            this.lblTemporadasSerie.TabIndex = 2;
            this.lblTemporadasSerie.Text = "Temporadas: ";
            // 
            // lblRateSerie
            // 
            this.lblRateSerie.AutoSize = true;
            this.lblRateSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblRateSerie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblRateSerie.Location = new System.Drawing.Point(784, 235);
            this.lblRateSerie.Name = "lblRateSerie";
            this.lblRateSerie.Size = new System.Drawing.Size(95, 21);
            this.lblRateSerie.TabIndex = 3;
            this.lblRateSerie.Text = "Puntuación: ";
            // 
            // lblYearSerie
            // 
            this.lblYearSerie.AutoSize = true;
            this.lblYearSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblYearSerie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblYearSerie.Location = new System.Drawing.Point(784, 193);
            this.lblYearSerie.Name = "lblYearSerie";
            this.lblYearSerie.Size = new System.Drawing.Size(45, 21);
            this.lblYearSerie.TabIndex = 4;
            this.lblYearSerie.Text = "Año: ";
            // 
            // cmbGenresSerie
            // 
            this.cmbGenresSerie.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbGenresSerie.FormattingEnabled = true;
            this.cmbGenresSerie.Location = new System.Drawing.Point(92, 78);
            this.cmbGenresSerie.Name = "cmbGenresSerie";
            this.cmbGenresSerie.Size = new System.Drawing.Size(177, 29);
            this.cmbGenresSerie.TabIndex = 6;
            this.cmbGenresSerie.TabStop = false;
            this.cmbGenresSerie.Text = "Todos";
            // 
            // lblGenreSerie
            // 
            this.lblGenreSerie.AutoSize = true;
            this.lblGenreSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblGenreSerie.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGenreSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblGenreSerie.Location = new System.Drawing.Point(12, 81);
            this.lblGenreSerie.Name = "lblGenreSerie";
            this.lblGenreSerie.Size = new System.Drawing.Size(61, 21);
            this.lblGenreSerie.TabIndex = 7;
            this.lblGenreSerie.Text = "Género";
            // 
            // btnPlaySerie
            // 
            this.btnPlaySerie.Image = global::Krakflix.Properties.Resources.playy;
            this.btnPlaySerie.Location = new System.Drawing.Point(1121, 107);
            this.btnPlaySerie.Name = "btnPlaySerie";
            this.btnPlaySerie.Size = new System.Drawing.Size(110, 107);
            this.btnPlaySerie.TabIndex = 9;
            this.btnPlaySerie.Text = " ";
            this.btnPlaySerie.UseVisualStyleBackColor = true;
            this.btnPlaySerie.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // listBoxSeries
            // 
            this.listBoxSeries.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxSeries.FormattingEnabled = true;
            this.listBoxSeries.ItemHeight = 21;
            this.listBoxSeries.Location = new System.Drawing.Point(67, 153);
            this.listBoxSeries.Name = "listBoxSeries";
            this.listBoxSeries.Size = new System.Drawing.Size(253, 340);
            this.listBoxSeries.TabIndex = 11;
            this.listBoxSeries.DoubleClick += new System.EventHandler(this.listBoxSeries_DoubleClick);
            // 
            // lblTituloSerieDescripcion
            // 
            this.lblTituloSerieDescripcion.AutoSize = true;
            this.lblTituloSerieDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloSerieDescripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTituloSerieDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTituloSerieDescripcion.Location = new System.Drawing.Point(404, 304);
            this.lblTituloSerieDescripcion.Name = "lblTituloSerieDescripcion";
            this.lblTituloSerieDescripcion.Size = new System.Drawing.Size(124, 30);
            this.lblTituloSerieDescripcion.TabIndex = 13;
            this.lblTituloSerieDescripcion.Text = "Descripción";
            // 
            // lblcap
            // 
            this.lblcap.AutoSize = true;
            this.lblcap.BackColor = System.Drawing.Color.Transparent;
            this.lblcap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblcap.Location = new System.Drawing.Point(1014, 280);
            this.lblcap.Name = "lblcap";
            this.lblcap.Size = new System.Drawing.Size(82, 21);
            this.lblcap.TabIndex = 15;
            this.lblcap.Text = "Capítulos: ";
            // 
            // cmbCaps
            // 
            this.cmbCaps.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCaps.FormattingEnabled = true;
            this.cmbCaps.Location = new System.Drawing.Point(1121, 278);
            this.cmbCaps.MaxDropDownItems = 10;
            this.cmbCaps.Name = "cmbCaps";
            this.cmbCaps.Size = new System.Drawing.Size(209, 28);
            this.cmbCaps.TabIndex = 16;
            this.cmbCaps.TabStop = false;
            this.cmbCaps.Text = "Selecciona uno";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTemp.Location = new System.Drawing.Point(785, 280);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(94, 21);
            this.lblTemp.TabIndex = 17;
            this.lblTemp.Text = "Temporada: ";
            // 
            // cmbTemp
            // 
            this.cmbTemp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTemp.FormattingEnabled = true;
            this.cmbTemp.Location = new System.Drawing.Point(885, 278);
            this.cmbTemp.Name = "cmbTemp";
            this.cmbTemp.Size = new System.Drawing.Size(91, 28);
            this.cmbTemp.TabIndex = 18;
            this.cmbTemp.TabStop = false;
            this.cmbTemp.Text = "Elije";
            this.cmbTemp.SelectedIndexChanged += new System.EventHandler(this.cmbTemp_SelectedIndexChanged);
            this.cmbTemp.SelectionChangeCommitted += new System.EventHandler(this.cmbTemp_SelectionChangeCommitted);
            // 
            // lblDescripcionSerie
            // 
            this.lblDescripcionSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionSerie.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescripcionSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblDescripcionSerie.Location = new System.Drawing.Point(405, 352);
            this.lblDescripcionSerie.Name = "lblDescripcionSerie";
            this.lblDescripcionSerie.Size = new System.Drawing.Size(735, 380);
            this.lblDescripcionSerie.TabIndex = 14;
            // 
            // btnBuscarSerie
            // 
            this.btnBuscarSerie.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSerie.Image")));
            this.btnBuscarSerie.Location = new System.Drawing.Point(281, 76);
            this.btnBuscarSerie.Name = "btnBuscarSerie";
            this.btnBuscarSerie.Size = new System.Drawing.Size(39, 35);
            this.btnBuscarSerie.TabIndex = 35;
            this.btnBuscarSerie.UseVisualStyleBackColor = true;
            this.btnBuscarSerie.Click += new System.EventHandler(this.btnBuscarSerie_Click);
            // 
            // SeriesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Krakflix.Properties.Resources.backk;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.btnBuscarSerie);
            this.Controls.Add(this.cmbTemp);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.cmbCaps);
            this.Controls.Add(this.lblcap);
            this.Controls.Add(this.lblDescripcionSerie);
            this.Controls.Add(this.lblTituloSerieDescripcion);
            this.Controls.Add(this.listBoxSeries);
            this.Controls.Add(this.btnPlaySerie);
            this.Controls.Add(this.lblGenreSerie);
            this.Controls.Add(this.cmbGenresSerie);
            this.Controls.Add(this.lblYearSerie);
            this.Controls.Add(this.lblRateSerie);
            this.Controls.Add(this.lblTemporadasSerie);
            this.Controls.Add(this.lblTituloSerie);
            this.Controls.Add(this.imgSerie);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(237, 13);
            this.Name = "SeriesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Series";
            ((System.ComponentModel.ISupportInitialize)(this.imgSerie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.PictureBox imgSerie;
        private System.Windows.Forms.Label lblTituloSerie;
        private System.Windows.Forms.Label lblTemporadasSerie;
        private System.Windows.Forms.Label lblRateSerie;
        private System.Windows.Forms.Label lblYearSerie;
        private System.Windows.Forms.ComboBox cmbGenresSerie;
        private System.Windows.Forms.Label lblGenreSerie;
        private System.Windows.Forms.Button btnPlaySerie;
        private System.Windows.Forms.ListBox listBoxSeries;
        private System.Windows.Forms.Label lblTituloSerieDescripcion;
        private Label lblcap;
        private ComboBox cmbCaps;
        private Label lblTemp;
        private ComboBox cmbTemp;
        private Label lblDescripcionSerie;
        private Button btnBuscarSerie;
    }
}