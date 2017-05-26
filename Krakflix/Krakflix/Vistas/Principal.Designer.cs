using System.Windows.Forms;
namespace Krakflix
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.lblPeliculas = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblAñadirPeli = new System.Windows.Forms.ToolStripLabel();
            this.lblModificarPeli = new System.Windows.Forms.ToolStripLabel();
            this.lblEliminarPeli = new System.Windows.Forms.ToolStripLabel();
            this.lblEspacio = new System.Windows.Forms.ToolStripLabel();
            this.lblSeries = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblAñadirSerie = new System.Windows.Forms.ToolStripLabel();
            this.lblModificarSerie = new System.Windows.Forms.ToolStripLabel();
            this.lblEliminarSerie = new System.Windows.Forms.ToolStripLabel();
            this.lblUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblPass = new System.Windows.Forms.ToolStripLabel();
            this.lblFoto = new System.Windows.Forms.ToolStripLabel();
            this.PlayerPeli = new AxWMPLib.AxWindowsMediaPlayer();
            this.PlayerSerie = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblVideoPeli = new System.Windows.Forms.Label();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblVideoSerie = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblWelcome.Location = new System.Drawing.Point(237, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(86, 21);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "WELCOME";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.tsMenu);
            this.panelMenu.Location = new System.Drawing.Point(12, 268);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(99, 311);
            this.panelMenu.TabIndex = 2;
            // 
            // tsMenu
            // 
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPeliculas,
            this.toolStripSeparator1,
            this.lblAñadirPeli,
            this.lblModificarPeli,
            this.lblEliminarPeli,
            this.lblEspacio,
            this.lblSeries,
            this.toolStripSeparator2,
            this.lblAñadirSerie,
            this.lblModificarSerie,
            this.lblEliminarSerie,
            this.lblUser,
            this.toolStripSeparator3,
            this.lblPass,
            this.lblFoto});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(99, 311);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // lblPeliculas
            // 
            this.lblPeliculas.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeliculas.Name = "lblPeliculas";
            this.lblPeliculas.Size = new System.Drawing.Size(96, 30);
            this.lblPeliculas.Text = "Películas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(96, 6);
            // 
            // lblAñadirPeli
            // 
            this.lblAñadirPeli.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAñadirPeli.Name = "lblAñadirPeli";
            this.lblAñadirPeli.Size = new System.Drawing.Size(96, 20);
            this.lblAñadirPeli.Text = "-Añadir";
            this.lblAñadirPeli.Click += new System.EventHandler(this.lblAñadirPeli_Click);
            // 
            // lblModificarPeli
            // 
            this.lblModificarPeli.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblModificarPeli.Name = "lblModificarPeli";
            this.lblModificarPeli.Size = new System.Drawing.Size(96, 20);
            this.lblModificarPeli.Text = "-Modificar";
            this.lblModificarPeli.Click += new System.EventHandler(this.lblModificarPeli_Click);
            // 
            // lblEliminarPeli
            // 
            this.lblEliminarPeli.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEliminarPeli.Name = "lblEliminarPeli";
            this.lblEliminarPeli.Size = new System.Drawing.Size(96, 20);
            this.lblEliminarPeli.Text = "-Eliminar";
            this.lblEliminarPeli.Click += new System.EventHandler(this.lblEliminarPeli_Click);
            // 
            // lblEspacio
            // 
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(96, 0);
            // 
            // lblSeries
            // 
            this.lblSeries.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(96, 30);
            this.lblSeries.Text = "SERIES";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(96, 6);
            // 
            // lblAñadirSerie
            // 
            this.lblAñadirSerie.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAñadirSerie.Name = "lblAñadirSerie";
            this.lblAñadirSerie.Size = new System.Drawing.Size(96, 20);
            this.lblAñadirSerie.Text = "-Añadir";
            this.lblAñadirSerie.Click += new System.EventHandler(this.lblAñadirSerie_Click);
            // 
            // lblModificarSerie
            // 
            this.lblModificarSerie.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblModificarSerie.Name = "lblModificarSerie";
            this.lblModificarSerie.Size = new System.Drawing.Size(96, 20);
            this.lblModificarSerie.Text = "-Modificar";
            this.lblModificarSerie.Click += new System.EventHandler(this.lblModificarSerie_Click);
            // 
            // lblEliminarSerie
            // 
            this.lblEliminarSerie.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEliminarSerie.Name = "lblEliminarSerie";
            this.lblEliminarSerie.Size = new System.Drawing.Size(96, 20);
            this.lblEliminarSerie.Text = "-Eliminar";
            this.lblEliminarSerie.Click += new System.EventHandler(this.lblEliminarSerie_Click);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(96, 30);
            this.lblUser.Text = "Usuario";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(96, 6);
            // 
            // lblPass
            // 
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(96, 20);
            this.lblPass.Text = "-Contraseña";
            this.lblPass.Click += new System.EventHandler(this.lblPass_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(45, 20);
            this.lblFoto.Text = "-Foto";
            this.lblFoto.Click += new System.EventHandler(this.lblFoto_Click);
            // 
            // PlayerPeli
            // 
            this.PlayerPeli.Enabled = true;
            this.PlayerPeli.Location = new System.Drawing.Point(523, 372);
            this.PlayerPeli.Name = "PlayerPeli";
            this.PlayerPeli.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PlayerPeli.OcxState")));
            this.PlayerPeli.Size = new System.Drawing.Size(647, 279);
            this.PlayerPeli.TabIndex = 3;
            this.PlayerPeli.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.VideoPelisClick);
            this.PlayerPeli.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.PlayerPeli_MouseMoveEvent);
            // 
            // PlayerSerie
            // 
            this.PlayerSerie.Enabled = true;
            this.PlayerSerie.Location = new System.Drawing.Point(523, 53);
            this.PlayerSerie.Name = "PlayerSerie";
            this.PlayerSerie.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PlayerSerie.OcxState")));
            this.PlayerSerie.Size = new System.Drawing.Size(647, 279);
            this.PlayerSerie.TabIndex = 4;
            this.PlayerSerie.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.VideoSeriesClick);
            this.PlayerSerie.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.PlayerSerie_MouseMoveEvent);
            // 
            // lblVideoPeli
            // 
            this.lblVideoPeli.AutoSize = true;
            this.lblVideoPeli.BackColor = System.Drawing.Color.Black;
            this.lblVideoPeli.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoPeli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblVideoPeli.Location = new System.Drawing.Point(795, 504);
            this.lblVideoPeli.Name = "lblVideoPeli";
            this.lblVideoPeli.Size = new System.Drawing.Size(105, 25);
            this.lblVideoPeli.TabIndex = 5;
            this.lblVideoPeli.Text = "PELICULAS";
            this.lblVideoPeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVideoPeli.Visible = false;
            this.lblVideoPeli.Click += new System.EventHandler(this.lblVideoPelisClick);
            // 
            // imgUser
            // 
            this.imgUser.BackColor = System.Drawing.Color.Transparent;
            this.imgUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgUser.Location = new System.Drawing.Point(0, 1);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(230, 207);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 0;
            this.imgUser.TabStop = false;
            // 
            // lblVideoSerie
            // 
            this.lblVideoSerie.AutoSize = true;
            this.lblVideoSerie.BackColor = System.Drawing.Color.Black;
            this.lblVideoSerie.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblVideoSerie.Location = new System.Drawing.Point(806, 183);
            this.lblVideoSerie.Name = "lblVideoSerie";
            this.lblVideoSerie.Size = new System.Drawing.Size(72, 25);
            this.lblVideoSerie.TabIndex = 6;
            this.lblVideoSerie.Text = "SERIES";
            this.lblVideoSerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVideoSerie.Click += new System.EventHandler(this.lblVideoSerie_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.BackgroundImage = global::Krakflix.Properties.Resources.backk;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.lblVideoSerie);
            this.Controls.Add(this.lblVideoPeli);
            this.Controls.Add(this.PlayerSerie);
            this.Controls.Add(this.PlayerPeli);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.imgUser);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krakflix";
            this.MouseEnter += new System.EventHandler(this.Principal_MouseEnter);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox imgUser;
        private Label lblWelcome;
        private Panel panelMenu;
        private ToolStrip tsMenu;
        private ToolStripLabel lblPeliculas;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblAñadirPeli;
        private ToolStripLabel lblModificarPeli;
        private ToolStripLabel lblEliminarPeli;
        private ToolStripLabel lblEspacio;
        private ToolStripLabel lblSeries;
        private ToolStripSeparator toolStripSeparator2;
        private BindingSource bindingSource1;
        private ToolStripLabel lblAñadirSerie;
        private ToolStripLabel lblModificarSerie;
        private ToolStripLabel lblEliminarSerie;
        private ToolStripLabel lblUser;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel lblPass;
        private ToolStripLabel lblFoto;
        private AxWMPLib.AxWindowsMediaPlayer PlayerPeli;
        private AxWMPLib.AxWindowsMediaPlayer PlayerSerie;
        private Label lblVideoPeli;
        private Label lblVideoSerie;
    }
}

