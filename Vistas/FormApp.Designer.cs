namespace Editor
{
    partial class FormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.openFileDialogNewArchivo = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbrirArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNombreArchivo = new System.Windows.Forms.Label();
            this.saveFileDialogGuardarMp3 = new System.Windows.Forms.SaveFileDialog();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panelRemoverAudio = new System.Windows.Forms.Panel();
            this.buttonRemoverAudio = new System.Windows.Forms.Button();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelResolucion = new System.Windows.Forms.Panel();
            this.panelImagenes = new System.Windows.Forms.Panel();
            this.panelAudio = new System.Windows.Forms.Panel();
            this.panelConvertir = new System.Windows.Forms.Panel();
            this.buttonFormatos = new System.Windows.Forms.Button();
            this.buttonExAudio = new System.Windows.Forms.Button();
            this.buttonResolucion = new System.Windows.Forms.Button();
            this.buttonExtraerImagenes = new System.Windows.Forms.Button();
            this.labelCampoNombre = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.saveFileDialogRemoverAudio = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogNewArchivo
            // 
            this.openFileDialogNewArchivo.FileName = "openFileDialogArchivo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoToolStripMenuItem,
            this.ToolStripMenuItemCuenta});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbrirArchivo});
            this.abrirArchivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(75, 28);
            this.abrirArchivoToolStripMenuItem.Text = "Archivo";
            // 
            // toolStripMenuItemAbrirArchivo
            // 
            this.toolStripMenuItemAbrirArchivo.Name = "toolStripMenuItemAbrirArchivo";
            this.toolStripMenuItemAbrirArchivo.Size = new System.Drawing.Size(172, 26);
            this.toolStripMenuItemAbrirArchivo.Text = "Abrir Archivo";
            this.toolStripMenuItemAbrirArchivo.Click += new System.EventHandler(this.toolStripMenuItemAbrirArchivo_Click);
            // 
            // ToolStripMenuItemCuenta
            // 
            this.ToolStripMenuItemCuenta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripMenuItemCuenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCerrarSesion});
            this.ToolStripMenuItemCuenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemCuenta.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemCuenta.Image")));
            this.ToolStripMenuItemCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolStripMenuItemCuenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItemCuenta.Name = "ToolStripMenuItemCuenta";
            this.ToolStripMenuItemCuenta.Size = new System.Drawing.Size(95, 28);
            this.ToolStripMenuItemCuenta.Text = "Cuenta";
            // 
            // ToolStripMenuItemCerrarSesion
            // 
            this.ToolStripMenuItemCerrarSesion.Name = "ToolStripMenuItemCerrarSesion";
            this.ToolStripMenuItemCerrarSesion.Size = new System.Drawing.Size(174, 26);
            this.ToolStripMenuItemCerrarSesion.Text = "Cerrar Sesion";
            this.ToolStripMenuItemCerrarSesion.Click += new System.EventHandler(this.ToolStripMenuItemCerrarSesion_Click);
            // 
            // labelNombreArchivo
            // 
            this.labelNombreArchivo.AutoSize = true;
            this.labelNombreArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.labelNombreArchivo.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreArchivo.Location = new System.Drawing.Point(420, 45);
            this.labelNombreArchivo.Name = "labelNombreArchivo";
            this.labelNombreArchivo.Size = new System.Drawing.Size(241, 18);
            this.labelNombreArchivo.TabIndex = 7;
            this.labelNombreArchivo.Text = "Seleccione un archivo de video";
            // 
            // saveFileDialogGuardarMp3
            // 
            this.saveFileDialogGuardarMp3.Filter = "Archivo de  audio (*.mp3)|*.mp3";
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.panelBotones.Controls.Add(this.panelRemoverAudio);
            this.panelBotones.Controls.Add(this.buttonRemoverAudio);
            this.panelBotones.Controls.Add(this.panelVideo);
            this.panelBotones.Controls.Add(this.buttonPlay);
            this.panelBotones.Controls.Add(this.panelResolucion);
            this.panelBotones.Controls.Add(this.panelImagenes);
            this.panelBotones.Controls.Add(this.panelAudio);
            this.panelBotones.Controls.Add(this.panelConvertir);
            this.panelBotones.Controls.Add(this.buttonFormatos);
            this.panelBotones.Controls.Add(this.buttonExAudio);
            this.panelBotones.Controls.Add(this.buttonResolucion);
            this.panelBotones.Controls.Add(this.buttonExtraerImagenes);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(0, 32);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(200, 361);
            this.panelBotones.TabIndex = 23;
            // 
            // panelRemoverAudio
            // 
            this.panelRemoverAudio.BackColor = System.Drawing.Color.White;
            this.panelRemoverAudio.Location = new System.Drawing.Point(0, 303);
            this.panelRemoverAudio.Name = "panelRemoverAudio";
            this.panelRemoverAudio.Size = new System.Drawing.Size(4, 54);
            this.panelRemoverAudio.TabIndex = 24;
            this.panelRemoverAudio.Visible = false;
            // 
            // buttonRemoverAudio
            // 
            this.buttonRemoverAudio.FlatAppearance.BorderSize = 0;
            this.buttonRemoverAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoverAudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.buttonRemoverAudio.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoverAudio.Image")));
            this.buttonRemoverAudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoverAudio.Location = new System.Drawing.Point(3, 303);
            this.buttonRemoverAudio.Name = "buttonRemoverAudio";
            this.buttonRemoverAudio.Size = new System.Drawing.Size(199, 54);
            this.buttonRemoverAudio.TabIndex = 25;
            this.buttonRemoverAudio.Text = "REMOVER AUDIO";
            this.buttonRemoverAudio.UseVisualStyleBackColor = true;
            this.buttonRemoverAudio.Click += new System.EventHandler(this.buttonRemoverAudio_Click);
            // 
            // panelVideo
            // 
            this.panelVideo.BackColor = System.Drawing.Color.White;
            this.panelVideo.Location = new System.Drawing.Point(0, 3);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(4, 54);
            this.panelVideo.TabIndex = 22;
            this.panelVideo.Visible = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlay.Location = new System.Drawing.Point(3, 3);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(199, 54);
            this.buttonPlay.TabIndex = 23;
            this.buttonPlay.Text = "VER VIDEO";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // panelResolucion
            // 
            this.panelResolucion.BackColor = System.Drawing.Color.White;
            this.panelResolucion.Location = new System.Drawing.Point(0, 63);
            this.panelResolucion.Name = "panelResolucion";
            this.panelResolucion.Size = new System.Drawing.Size(4, 54);
            this.panelResolucion.TabIndex = 3;
            this.panelResolucion.Visible = false;
            // 
            // panelImagenes
            // 
            this.panelImagenes.BackColor = System.Drawing.Color.White;
            this.panelImagenes.Location = new System.Drawing.Point(0, 123);
            this.panelImagenes.Name = "panelImagenes";
            this.panelImagenes.Size = new System.Drawing.Size(4, 54);
            this.panelImagenes.TabIndex = 2;
            this.panelImagenes.Visible = false;
            // 
            // panelAudio
            // 
            this.panelAudio.BackColor = System.Drawing.Color.White;
            this.panelAudio.Location = new System.Drawing.Point(0, 243);
            this.panelAudio.Name = "panelAudio";
            this.panelAudio.Size = new System.Drawing.Size(4, 54);
            this.panelAudio.TabIndex = 1;
            this.panelAudio.Visible = false;
            // 
            // panelConvertir
            // 
            this.panelConvertir.BackColor = System.Drawing.Color.White;
            this.panelConvertir.Location = new System.Drawing.Point(0, 183);
            this.panelConvertir.Name = "panelConvertir";
            this.panelConvertir.Size = new System.Drawing.Size(4, 54);
            this.panelConvertir.TabIndex = 0;
            this.panelConvertir.Visible = false;
            // 
            // buttonFormatos
            // 
            this.buttonFormatos.FlatAppearance.BorderSize = 0;
            this.buttonFormatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.buttonFormatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonFormatos.Image")));
            this.buttonFormatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFormatos.Location = new System.Drawing.Point(3, 183);
            this.buttonFormatos.Name = "buttonFormatos";
            this.buttonFormatos.Size = new System.Drawing.Size(199, 54);
            this.buttonFormatos.TabIndex = 21;
            this.buttonFormatos.Text = "CONVERTIR VIDEO";
            this.buttonFormatos.UseVisualStyleBackColor = true;
            this.buttonFormatos.Click += new System.EventHandler(this.ButtonFormatos_Click);
            // 
            // buttonExAudio
            // 
            this.buttonExAudio.FlatAppearance.BorderSize = 0;
            this.buttonExAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExAudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.buttonExAudio.Image = ((System.Drawing.Image)(resources.GetObject("buttonExAudio.Image")));
            this.buttonExAudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExAudio.Location = new System.Drawing.Point(3, 243);
            this.buttonExAudio.Name = "buttonExAudio";
            this.buttonExAudio.Size = new System.Drawing.Size(199, 54);
            this.buttonExAudio.TabIndex = 2;
            this.buttonExAudio.Text = "EXTRAER AUDIO";
            this.buttonExAudio.UseVisualStyleBackColor = true;
            this.buttonExAudio.Click += new System.EventHandler(this.buttonExAudio_Click);
            // 
            // buttonResolucion
            // 
            this.buttonResolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.buttonResolucion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonResolucion.FlatAppearance.BorderSize = 0;
            this.buttonResolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResolucion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.buttonResolucion.Image = ((System.Drawing.Image)(resources.GetObject("buttonResolucion.Image")));
            this.buttonResolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResolucion.Location = new System.Drawing.Point(3, 63);
            this.buttonResolucion.Name = "buttonResolucion";
            this.buttonResolucion.Size = new System.Drawing.Size(199, 54);
            this.buttonResolucion.TabIndex = 4;
            this.buttonResolucion.Text = "RESOLUCION";
            this.buttonResolucion.UseVisualStyleBackColor = false;
            this.buttonResolucion.Click += new System.EventHandler(this.buttonResolucion_Click);
            // 
            // buttonExtraerImagenes
            // 
            this.buttonExtraerImagenes.FlatAppearance.BorderSize = 0;
            this.buttonExtraerImagenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtraerImagenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.buttonExtraerImagenes.Image = ((System.Drawing.Image)(resources.GetObject("buttonExtraerImagenes.Image")));
            this.buttonExtraerImagenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExtraerImagenes.Location = new System.Drawing.Point(3, 123);
            this.buttonExtraerImagenes.Name = "buttonExtraerImagenes";
            this.buttonExtraerImagenes.Size = new System.Drawing.Size(199, 54);
            this.buttonExtraerImagenes.TabIndex = 5;
            this.buttonExtraerImagenes.Text = "EXTRAER IMAGENES";
            this.buttonExtraerImagenes.UseVisualStyleBackColor = true;
            this.buttonExtraerImagenes.Click += new System.EventHandler(this.buttonExtraerImagenes_Click);
            // 
            // labelCampoNombre
            // 
            this.labelCampoNombre.AutoSize = true;
            this.labelCampoNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.labelCampoNombre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampoNombre.Image = ((System.Drawing.Image)(resources.GetObject("labelCampoNombre.Image")));
            this.labelCampoNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCampoNombre.Location = new System.Drawing.Point(206, 41);
            this.labelCampoNombre.Name = "labelCampoNombre";
            this.labelCampoNombre.Size = new System.Drawing.Size(208, 23);
            this.labelCampoNombre.TabIndex = 22;
            this.labelCampoNombre.Text = "       Archivo seleccionado:";
            this.labelCampoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Location = new System.Drawing.Point(200, 74);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(611, 320);
            this.panelForm.TabIndex = 24;
            // 
            // FormApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(811, 393);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelCampoNombre);
            this.Controls.Add(this.labelNombreArchivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simplex Video Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialogNewArchivo;
        private System.Windows.Forms.Button buttonExAudio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbrirArchivo;
        private System.Windows.Forms.Button buttonResolucion;
        private System.Windows.Forms.Button buttonExtraerImagenes;
        private System.Windows.Forms.Label labelNombreArchivo;
        private System.Windows.Forms.SaveFileDialog saveFileDialogGuardarMp3;
        private System.Windows.Forms.Button buttonFormatos;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCuenta;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCerrarSesion;
        private System.Windows.Forms.Label labelCampoNombre;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelResolucion;
        private System.Windows.Forms.Panel panelImagenes;
        private System.Windows.Forms.Panel panelAudio;
        private System.Windows.Forms.Panel panelConvertir;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Panel panelRemoverAudio;
        private System.Windows.Forms.Button buttonRemoverAudio;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.SaveFileDialog saveFileDialogRemoverAudio;
    }
}