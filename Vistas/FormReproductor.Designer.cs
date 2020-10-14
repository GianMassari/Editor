namespace Editor
{
    partial class FormReproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReproductor));
            this.axWindowsMediaPlayerReproductor = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerReproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayerReproductor
            // 
            this.axWindowsMediaPlayerReproductor.Enabled = true;
            this.axWindowsMediaPlayerReproductor.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayerReproductor.Name = "axWindowsMediaPlayerReproductor";
            this.axWindowsMediaPlayerReproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerReproductor.OcxState")));
            this.axWindowsMediaPlayerReproductor.Size = new System.Drawing.Size(611, 320);
            this.axWindowsMediaPlayerReproductor.TabIndex = 0;
            // 
            // FormReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 320);
            this.Controls.Add(this.axWindowsMediaPlayerReproductor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReproductor";
            this.Text = "FormReproductor";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerReproductor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerReproductor;
    }
}