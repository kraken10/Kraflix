﻿namespace Krakflix.Vistas
{
    partial class VideoOnline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoOnline));
            this.ShockwaveFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.ShockwaveFlash)).BeginInit();
            this.SuspendLayout();
            // 
            // ShockwaveFlash
            // 
            this.ShockwaveFlash.Enabled = true;
            this.ShockwaveFlash.Location = new System.Drawing.Point(-2, -1);
            this.ShockwaveFlash.Name = "ShockwaveFlash";
            this.ShockwaveFlash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ShockwaveFlash.OcxState")));
            this.ShockwaveFlash.Size = new System.Drawing.Size(1059, 534);
            this.ShockwaveFlash.TabIndex = 0;
            // 
            // VideoOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 531);
            this.Controls.Add(this.ShockwaveFlash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VideoOnline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproducir";
            this.Load += new System.EventHandler(this.VideoOnline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShockwaveFlash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash ShockwaveFlash;
    }
}