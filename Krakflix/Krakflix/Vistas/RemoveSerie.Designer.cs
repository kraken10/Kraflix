namespace Krakflix.Vistas
{
    partial class RemoveSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveSerie));
            this.listBoxSeries = new System.Windows.Forms.ListBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cmbGenres = new System.Windows.Forms.ComboBox();
            this.btnBuscarSerie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSeries
            // 
            this.listBoxSeries.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxSeries.FormattingEnabled = true;
            this.listBoxSeries.ItemHeight = 21;
            this.listBoxSeries.Location = new System.Drawing.Point(209, 103);
            this.listBoxSeries.Name = "listBoxSeries";
            this.listBoxSeries.Size = new System.Drawing.Size(253, 298);
            this.listBoxSeries.TabIndex = 20;
            this.listBoxSeries.SelectedIndexChanged += new System.EventHandler(this.listBoxSeries_SelectedIndexChanged);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblGenre.Location = new System.Drawing.Point(164, 38);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(61, 21);
            this.lblGenre.TabIndex = 18;
            this.lblGenre.Text = "Género";
            // 
            // cmbGenres
            // 
            this.cmbGenres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbGenres.FormattingEnabled = true;
            this.cmbGenres.Location = new System.Drawing.Point(244, 35);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(177, 29);
            this.cmbGenres.TabIndex = 17;
            this.cmbGenres.TabStop = false;
            this.cmbGenres.Text = "Todos";
            // 
            // btnBuscarSerie
            // 
            this.btnBuscarSerie.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSerie.Image")));
            this.btnBuscarSerie.Location = new System.Drawing.Point(440, 33);
            this.btnBuscarSerie.Name = "btnBuscarSerie";
            this.btnBuscarSerie.Size = new System.Drawing.Size(39, 35);
            this.btnBuscarSerie.TabIndex = 37;
            this.btnBuscarSerie.UseVisualStyleBackColor = true;
            this.btnBuscarSerie.Click += new System.EventHandler(this.btnBuscarSerie_Click);
            // 
            // RemoveSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Krakflix.Properties.Resources.backk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 437);
            this.Controls.Add(this.btnBuscarSerie);
            this.Controls.Add(this.listBoxSeries);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cmbGenres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoveSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveSerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSeries;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cmbGenres;
        private System.Windows.Forms.Button btnBuscarSerie;
    }
}