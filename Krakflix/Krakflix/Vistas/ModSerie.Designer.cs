﻿namespace Krakflix.Vistas
{
    partial class ModSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModSerie));
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblRate2 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cmbGenreMod = new System.Windows.Forms.ComboBox();
            this.txtTemporadas = new System.Windows.Forms.TextBox();
            this.listBoxSeries = new System.Windows.Forms.ListBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cmbGenres = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.imgSerie = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenreMod = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCapitulosMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddChap = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgSerie)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(435, 274);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(389, 162);
            this.txtDescription.TabIndex = 45;
            // 
            // lblRate2
            // 
            this.lblRate2.AutoSize = true;
            this.lblRate2.BackColor = System.Drawing.Color.Transparent;
            this.lblRate2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblRate2.Location = new System.Drawing.Point(510, 191);
            this.lblRate2.Name = "lblRate2";
            this.lblRate2.Size = new System.Drawing.Size(34, 21);
            this.lblRate2.TabIndex = 42;
            this.lblRate2.Text = "/10";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(435, 191);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(58, 25);
            this.txtRate.TabIndex = 41;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(435, 152);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(90, 25);
            this.txtYear.TabIndex = 40;
            // 
            // cmbGenreMod
            // 
            this.cmbGenreMod.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbGenreMod.FormattingEnabled = true;
            this.cmbGenreMod.Location = new System.Drawing.Point(435, 107);
            this.cmbGenreMod.Name = "cmbGenreMod";
            this.cmbGenreMod.Size = new System.Drawing.Size(187, 29);
            this.cmbGenreMod.TabIndex = 39;
            this.cmbGenreMod.TabStop = false;
            this.cmbGenreMod.Text = "Selecciona";
            // 
            // txtTemporadas
            // 
            this.txtTemporadas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemporadas.Location = new System.Drawing.Point(435, 64);
            this.txtTemporadas.Name = "txtTemporadas";
            this.txtTemporadas.Size = new System.Drawing.Size(58, 25);
            this.txtTemporadas.TabIndex = 37;
            // 
            // listBoxSeries
            // 
            this.listBoxSeries.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxSeries.FormattingEnabled = true;
            this.listBoxSeries.ItemHeight = 21;
            this.listBoxSeries.Location = new System.Drawing.Point(32, 126);
            this.listBoxSeries.Name = "listBoxSeries";
            this.listBoxSeries.Size = new System.Drawing.Size(253, 277);
            this.listBoxSeries.TabIndex = 36;
            this.listBoxSeries.SelectedIndexChanged += new System.EventHandler(this.listBoxSeries_SelectedIndexChanged);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblGenre.Location = new System.Drawing.Point(7, 69);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(61, 21);
            this.lblGenre.TabIndex = 34;
            this.lblGenre.Text = "Género";
            // 
            // cmbGenres
            // 
            this.cmbGenres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbGenres.FormattingEnabled = true;
            this.cmbGenres.Location = new System.Drawing.Point(74, 66);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(163, 29);
            this.cmbGenres.TabIndex = 33;
            this.cmbGenres.TabStop = false;
            this.cmbGenres.Text = "Selecciona";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(435, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(187, 25);
            this.txtTitle.TabIndex = 32;
            // 
            // imgSerie
            // 
            this.imgSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSerie.Location = new System.Drawing.Point(654, 10);
            this.imgSerie.Name = "imgSerie";
            this.imgSerie.Size = new System.Drawing.Size(281, 205);
            this.imgSerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSerie.TabIndex = 31;
            this.imgSerie.TabStop = false;
            this.imgSerie.Click += new System.EventHandler(this.imgPeli_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblDescription.Location = new System.Drawing.Point(340, 274);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 21);
            this.lblDescription.TabIndex = 52;
            this.lblDescription.Text = "Descripción";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblRate.Location = new System.Drawing.Point(332, 191);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(88, 21);
            this.lblRate.TabIndex = 50;
            this.lblRate.Text = "Puntuación";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblYear.Location = new System.Drawing.Point(382, 152);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 21);
            this.lblYear.TabIndex = 49;
            this.lblYear.Text = "Año";
            // 
            // lblGenreMod
            // 
            this.lblGenreMod.AutoSize = true;
            this.lblGenreMod.BackColor = System.Drawing.Color.Transparent;
            this.lblGenreMod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblGenreMod.Location = new System.Drawing.Point(359, 110);
            this.lblGenreMod.Name = "lblGenreMod";
            this.lblGenreMod.Size = new System.Drawing.Size(61, 21);
            this.lblGenreMod.TabIndex = 48;
            this.lblGenreMod.Text = "Género";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTemp.Location = new System.Drawing.Point(332, 66);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(94, 21);
            this.lblTemp.TabIndex = 47;
            this.lblTemp.Text = "Temporadas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTitulo.Location = new System.Drawing.Point(371, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 21);
            this.lblTitulo.TabIndex = 46;
            this.lblTitulo.Text = "Título";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(577, 455);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(82, 31);
            this.btnModify.TabIndex = 53;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCapitulosMod
            // 
            this.btnCapitulosMod.Enabled = false;
            this.btnCapitulosMod.Location = new System.Drawing.Point(532, 234);
            this.btnCapitulosMod.Name = "btnCapitulosMod";
            this.btnCapitulosMod.Size = new System.Drawing.Size(71, 23);
            this.btnCapitulosMod.TabIndex = 54;
            this.btnCapitulosMod.Text = "Modificar";
            this.btnCapitulosMod.UseVisualStyleBackColor = true;
            this.btnCapitulosMod.Click += new System.EventHandler(this.btnCapitulos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(338, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Capítulos";
            // 
            // btnAddChap
            // 
            this.btnAddChap.Enabled = false;
            this.btnAddChap.Location = new System.Drawing.Point(435, 234);
            this.btnAddChap.Name = "btnAddChap";
            this.btnAddChap.Size = new System.Drawing.Size(71, 23);
            this.btnAddChap.TabIndex = 57;
            this.btnAddChap.Text = "Añadir";
            this.btnAddChap.UseVisualStyleBackColor = true;
            this.btnAddChap.Click += new System.EventHandler(this.btnAddChap_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(246, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 35);
            this.btnBuscar.TabIndex = 58;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ModSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Krakflix.Properties.Resources.backk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 537);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAddChap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCapitulosMod);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblGenreMod);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblRate2);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.cmbGenreMod);
            this.Controls.Add(this.txtTemporadas);
            this.Controls.Add(this.listBoxSeries);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cmbGenres);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.imgSerie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar serie";
            ((System.ComponentModel.ISupportInitialize)(this.imgSerie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblRate2;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbGenreMod;
        private System.Windows.Forms.TextBox txtTemporadas;
        private System.Windows.Forms.ListBox listBoxSeries;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cmbGenres;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.PictureBox imgSerie;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenreMod;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCapitulosMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddChap;
        private System.Windows.Forms.Button btnBuscar;
    }
}