using System.Windows.Forms;
namespace Krakflix.Vistas
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.PhotoUser = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoUser)).BeginInit();
            this.SuspendLayout();
            this.PhotoUser.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // PhotoUser
            // 
            this.PhotoUser.BackColor = System.Drawing.Color.Transparent;
            this.PhotoUser.BackgroundImage = global::Krakflix.Properties.Resources.defaultPhoto1;
            this.PhotoUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PhotoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhotoUser.Location = new System.Drawing.Point(1042, 29);
            this.PhotoUser.Name = "PhotoUser";
            this.PhotoUser.Size = new System.Drawing.Size(298, 303);
            this.PhotoUser.TabIndex = 1;
            this.PhotoUser.TabStop = false;
            this.PhotoUser.Click += new System.EventHandler(this.photoClick);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(1114, 359);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(164, 22);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "User";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(1114, 397);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(164, 22);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "Password";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(1114, 437);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(164, 22);
            this.txtPass2.TabIndex = 4;
            this.txtPass2.Text = "passwors";
            this.txtPass2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1156, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrarte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRegistro);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::Krakflix.Properties.Resources.starwars;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.PhotoUser);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private PictureBox PhotoUser;
        private TextBox txtUser;
        private TextBox txtPass;
        private TextBox txtPass2;
        private Button button1;
    }
}