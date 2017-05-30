namespace Krakflix.Vistas
{
    partial class ModCapitulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModCapitulos));
            this.lblCapitulos = new System.Windows.Forms.Label();
            this.cmbCap = new System.Windows.Forms.ComboBox();
            this.cmbTemp = new System.Windows.Forms.ComboBox();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbTempMod = new System.Windows.Forms.ComboBox();
            this.lblTemporadaMod = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnRuta = new System.Windows.Forms.Button();
            this.lblCorrecto = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCapitulos
            // 
            this.lblCapitulos.AutoSize = true;
            this.lblCapitulos.BackColor = System.Drawing.Color.Transparent;
            this.lblCapitulos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblCapitulos.Location = new System.Drawing.Point(223, 31);
            this.lblCapitulos.Name = "lblCapitulos";
            this.lblCapitulos.Size = new System.Drawing.Size(75, 21);
            this.lblCapitulos.TabIndex = 51;
            this.lblCapitulos.Text = "Capítulos";
            // 
            // cmbCap
            // 
            this.cmbCap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCap.FormattingEnabled = true;
            this.cmbCap.Location = new System.Drawing.Point(322, 28);
            this.cmbCap.MaxDropDownItems = 10;
            this.cmbCap.Name = "cmbCap";
            this.cmbCap.Size = new System.Drawing.Size(163, 29);
            this.cmbCap.TabIndex = 52;
            this.cmbCap.TabStop = false;
            this.cmbCap.Text = "Selecciona";
            this.cmbCap.SelectedIndexChanged += new System.EventHandler(this.cmbCap_SelectedIndexChanged);
            // 
            // cmbTemp
            // 
            this.cmbTemp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTemp.FormattingEnabled = true;
            this.cmbTemp.Location = new System.Drawing.Point(106, 28);
            this.cmbTemp.MaxDropDownItems = 10;
            this.cmbTemp.Name = "cmbTemp";
            this.cmbTemp.Size = new System.Drawing.Size(101, 29);
            this.cmbTemp.TabIndex = 54;
            this.cmbTemp.TabStop = false;
            this.cmbTemp.Text = "Selecciona";
            this.cmbTemp.SelectedIndexChanged += new System.EventHandler(this.cmbTemp_SelectedIndexChanged);
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.BackColor = System.Drawing.Color.Transparent;
            this.lblTemporada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemporada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTemporada.Location = new System.Drawing.Point(12, 31);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(87, 21);
            this.lblTemporada.TabIndex = 53;
            this.lblTemporada.Text = "Temporada";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTitulo.Location = new System.Drawing.Point(120, 90);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 21);
            this.lblTitulo.TabIndex = 56;
            this.lblTitulo.Text = "Título";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(184, 90);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(187, 25);
            this.txtTitle.TabIndex = 55;
            // 
            // cmbTempMod
            // 
            this.cmbTempMod.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTempMod.FormattingEnabled = true;
            this.cmbTempMod.Location = new System.Drawing.Point(184, 133);
            this.cmbTempMod.MaxDropDownItems = 10;
            this.cmbTempMod.Name = "cmbTempMod";
            this.cmbTempMod.Size = new System.Drawing.Size(101, 29);
            this.cmbTempMod.TabIndex = 58;
            this.cmbTempMod.TabStop = false;
            this.cmbTempMod.Text = "Selecciona";
            // 
            // lblTemporadaMod
            // 
            this.lblTemporadaMod.AutoSize = true;
            this.lblTemporadaMod.BackColor = System.Drawing.Color.Transparent;
            this.lblTemporadaMod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemporadaMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblTemporadaMod.Location = new System.Drawing.Point(82, 136);
            this.lblTemporadaMod.Name = "lblTemporadaMod";
            this.lblTemporadaMod.Size = new System.Drawing.Size(87, 21);
            this.lblTemporadaMod.TabIndex = 57;
            this.lblTemporadaMod.Text = "Temporada";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.BackColor = System.Drawing.Color.Transparent;
            this.lblRuta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblRuta.Location = new System.Drawing.Point(120, 182);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(42, 21);
            this.lblRuta.TabIndex = 59;
            this.lblRuta.Text = "Ruta";
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(184, 180);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(75, 23);
            this.btnRuta.TabIndex = 60;
            this.btnRuta.Text = "Cambiar";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // lblCorrecto
            // 
            this.lblCorrecto.AutoSize = true;
            this.lblCorrecto.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrecto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCorrecto.Location = new System.Drawing.Point(282, 182);
            this.lblCorrecto.Name = "lblCorrecto";
            this.lblCorrecto.Size = new System.Drawing.Size(70, 21);
            this.lblCorrecto.TabIndex = 61;
            this.lblCorrecto.Text = "Correcto";
            this.lblCorrecto.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(124, 319);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 62;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(286, 319);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 63;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(184, 228);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(187, 25);
            this.txtUrl.TabIndex = 64;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.BackColor = System.Drawing.Color.Transparent;
            this.lblUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblUrl.Location = new System.Drawing.Point(120, 228);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(31, 21);
            this.lblUrl.TabIndex = 65;
            this.lblUrl.Text = "Url";
            // 
            // ModCapitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Krakflix.Properties.Resources.backk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 412);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblCorrecto);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.cmbTempMod);
            this.Controls.Add(this.lblTemporadaMod);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cmbTemp);
            this.Controls.Add(this.lblTemporada);
            this.Controls.Add(this.cmbCap);
            this.Controls.Add(this.lblCapitulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModCapitulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModCapitulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapitulos;
        private System.Windows.Forms.ComboBox cmbCap;
        private System.Windows.Forms.ComboBox cmbTemp;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cmbTempMod;
        private System.Windows.Forms.Label lblTemporadaMod;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Label lblCorrecto;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
    }
}