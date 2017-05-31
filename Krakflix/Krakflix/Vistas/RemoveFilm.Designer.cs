namespace Krakflix.Vistas
{
    partial class RemoveFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveFilm));
            this.lblGenre = new System.Windows.Forms.Label();
            this.cmbGenres = new System.Windows.Forms.ComboBox();
            this.listBoxPelis = new System.Windows.Forms.ListBox();
            this.btnBuscarSerie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblGenre.Location = new System.Drawing.Point(155, 36);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(61, 21);
            this.lblGenre.TabIndex = 14;
            this.lblGenre.Text = "Género";
            // 
            // cmbGenres
            // 
            this.cmbGenres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbGenres.FormattingEnabled = true;
            this.cmbGenres.Location = new System.Drawing.Point(235, 33);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(177, 29);
            this.cmbGenres.TabIndex = 13;
            this.cmbGenres.TabStop = false;
            this.cmbGenres.Text = "Todos";
            // 
            // listBoxPelis
            // 
            this.listBoxPelis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxPelis.FormattingEnabled = true;
            this.listBoxPelis.ItemHeight = 21;
            this.listBoxPelis.Location = new System.Drawing.Point(200, 101);
            this.listBoxPelis.Name = "listBoxPelis";
            this.listBoxPelis.Size = new System.Drawing.Size(253, 298);
            this.listBoxPelis.TabIndex = 16;
            this.listBoxPelis.SelectedIndexChanged += new System.EventHandler(this.listBoxPelis_SelectedIndexChanged);
            // 
            // btnBuscarSerie
            // 
            this.btnBuscarSerie.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSerie.Image")));
            this.btnBuscarSerie.Location = new System.Drawing.Point(434, 31);
            this.btnBuscarSerie.Name = "btnBuscarSerie";
            this.btnBuscarSerie.Size = new System.Drawing.Size(39, 35);
            this.btnBuscarSerie.TabIndex = 36;
            this.btnBuscarSerie.UseVisualStyleBackColor = true;
            this.btnBuscarSerie.Click += new System.EventHandler(this.btnBuscarFilm);
            // 
            // RemoveFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Krakflix.Properties.Resources.backk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 437);
            this.Controls.Add(this.btnBuscarSerie);
            this.Controls.Add(this.listBoxPelis);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cmbGenres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RemoveFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveFilm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cmbGenres;
        private System.Windows.Forms.ListBox listBoxPelis;
        private System.Windows.Forms.Button btnBuscarSerie;
    }
}