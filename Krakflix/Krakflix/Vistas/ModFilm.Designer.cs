namespace Krakflix.Vistas
{
    partial class ModFilm
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
            this.imgPeli = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbGenres = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.listBoxPelis = new System.Windows.Forms.ListBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.cmbGenreMod = new System.Windows.Forms.ComboBox();
            this.lblGenreMod = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblRate2 = new System.Windows.Forms.Label();
            this.lblCorrecto = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnRuta = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPeli)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPeli
            // 
            this.imgPeli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPeli.Location = new System.Drawing.Point(717, 12);
            this.imgPeli.Name = "imgPeli";
            this.imgPeli.Size = new System.Drawing.Size(187, 205);
            this.imgPeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPeli.TabIndex = 1;
            this.imgPeli.TabStop = false;
            this.imgPeli.Click += new System.EventHandler(this.imgPeli_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(515, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(187, 25);
            this.txtTitle.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTitulo.Location = new System.Drawing.Point(449, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 21);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Título";
            // 
            // cmbGenres
            // 
            this.cmbGenres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbGenres.FormattingEnabled = true;
            this.cmbGenres.Location = new System.Drawing.Point(70, 68);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(163, 29);
            this.cmbGenres.TabIndex = 12;
            this.cmbGenres.TabStop = false;
            this.cmbGenres.Text = "Selecciona";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblGenre.Location = new System.Drawing.Point(3, 71);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(61, 21);
            this.lblGenre.TabIndex = 13;
            this.lblGenre.Text = "Género";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(239, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // listBoxPelis
            // 
            this.listBoxPelis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxPelis.FormattingEnabled = true;
            this.listBoxPelis.ItemHeight = 21;
            this.listBoxPelis.Location = new System.Drawing.Point(26, 129);
            this.listBoxPelis.Name = "listBoxPelis";
            this.listBoxPelis.Size = new System.Drawing.Size(253, 256);
            this.listBoxPelis.TabIndex = 15;
            this.listBoxPelis.SelectedIndexChanged += new System.EventHandler(this.listBoxPelis_SelectedIndexChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblDuration.Location = new System.Drawing.Point(425, 70);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(73, 21);
            this.lblDuration.TabIndex = 16;
            this.lblDuration.Text = "Duración";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(515, 69);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(58, 25);
            this.txtDuration.TabIndex = 17;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblMin.Location = new System.Drawing.Point(590, 70);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(37, 21);
            this.lblMin.TabIndex = 18;
            this.lblMin.Text = "Min";
            // 
            // cmbGenreMod
            // 
            this.cmbGenreMod.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbGenreMod.FormattingEnabled = true;
            this.cmbGenreMod.Location = new System.Drawing.Point(515, 112);
            this.cmbGenreMod.Name = "cmbGenreMod";
            this.cmbGenreMod.Size = new System.Drawing.Size(187, 29);
            this.cmbGenreMod.TabIndex = 20;
            this.cmbGenreMod.TabStop = false;
            this.cmbGenreMod.Text = "Selecciona";
            // 
            // lblGenreMod
            // 
            this.lblGenreMod.AutoSize = true;
            this.lblGenreMod.BackColor = System.Drawing.Color.Transparent;
            this.lblGenreMod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblGenreMod.Location = new System.Drawing.Point(437, 115);
            this.lblGenreMod.Name = "lblGenreMod";
            this.lblGenreMod.Size = new System.Drawing.Size(61, 21);
            this.lblGenreMod.TabIndex = 19;
            this.lblGenreMod.Text = "Género";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(515, 157);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(90, 25);
            this.txtYear.TabIndex = 22;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblYear.Location = new System.Drawing.Point(460, 157);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 21);
            this.lblYear.TabIndex = 21;
            this.lblYear.Text = "Año";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(515, 196);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(58, 25);
            this.txtRate.TabIndex = 24;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblRate.Location = new System.Drawing.Point(410, 196);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(88, 21);
            this.lblRate.TabIndex = 23;
            this.lblRate.Text = "Puntuación";
            // 
            // lblRate2
            // 
            this.lblRate2.AutoSize = true;
            this.lblRate2.BackColor = System.Drawing.Color.Transparent;
            this.lblRate2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblRate2.Location = new System.Drawing.Point(590, 196);
            this.lblRate2.Name = "lblRate2";
            this.lblRate2.Size = new System.Drawing.Size(34, 21);
            this.lblRate2.TabIndex = 25;
            this.lblRate2.Text = "/10";
            // 
            // lblCorrecto
            // 
            this.lblCorrecto.AutoSize = true;
            this.lblCorrecto.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrecto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCorrecto.Location = new System.Drawing.Point(572, 233);
            this.lblCorrecto.Name = "lblCorrecto";
            this.lblCorrecto.Size = new System.Drawing.Size(70, 21);
            this.lblCorrecto.TabIndex = 28;
            this.lblCorrecto.Text = "Correcto";
            this.lblCorrecto.Visible = false;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.BackColor = System.Drawing.Color.Transparent;
            this.lblRuta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblRuta.Location = new System.Drawing.Point(456, 233);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(42, 21);
            this.lblRuta.TabIndex = 27;
            this.lblRuta.Text = "Ruta";
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(514, 234);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(52, 23);
            this.btnRuta.TabIndex = 26;
            this.btnRuta.Text = "Elegir";
            this.btnRuta.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(515, 279);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(389, 162);
            this.txtDescription.TabIndex = 30;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblDescription.Location = new System.Drawing.Point(418, 279);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 21);
            this.lblDescription.TabIndex = 29;
            this.lblDescription.Text = "Descripción";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(667, 453);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(87, 65);
            this.btnModify.TabIndex = 31;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // ModFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Krakflix.Properties.Resources.backk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 530);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCorrecto);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.lblRate2);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbGenreMod);
            this.Controls.Add(this.lblGenreMod);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.listBoxPelis);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cmbGenres);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.imgPeli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar película";
            ((System.ComponentModel.ISupportInitialize)(this.imgPeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPeli;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbGenres;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox listBoxPelis;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.ComboBox cmbGenreMod;
        private System.Windows.Forms.Label lblGenreMod;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblRate2;
        private System.Windows.Forms.Label lblCorrecto;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnModify;
    }
}