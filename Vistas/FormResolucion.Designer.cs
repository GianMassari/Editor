namespace Editor
{
    partial class FormResolucion
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
            this.buttonCambiarResolucion = new System.Windows.Forms.Button();
            this.textBoxNumX = new System.Windows.Forms.TextBox();
            this.textBoxNumY = new System.Windows.Forms.TextBox();
            this.buttonExaminar = new System.Windows.Forms.Button();
            this.comboBoxResoluciones = new System.Windows.Forms.ComboBox();
            this.labelSeleccioneResolucion = new System.Windows.Forms.Label();
            this.labelResX = new System.Windows.Forms.Label();
            this.labelResY = new System.Windows.Forms.Label();
            this.groupBoxPersonalizada = new System.Windows.Forms.GroupBox();
            this.groupBoxResolucion = new System.Windows.Forms.GroupBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.textBoxNombreOut = new System.Windows.Forms.TextBox();
            this.labelNomConver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneOSToggleSwithResolucionPersonalizada = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.labelCarpertaSeleccionada = new System.Windows.Forms.Label();
            this.labelCarpetaDestino = new System.Windows.Forms.Label();
            this.folderBrowserDialogCarpetaSeleccionada = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxPersonalizada.SuspendLayout();
            this.groupBoxResolucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCambiarResolucion
            // 
            this.buttonCambiarResolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.buttonCambiarResolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCambiarResolucion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiarResolucion.ForeColor = System.Drawing.Color.Black;
            this.buttonCambiarResolucion.Location = new System.Drawing.Point(170, 197);
            this.buttonCambiarResolucion.Name = "buttonCambiarResolucion";
            this.buttonCambiarResolucion.Size = new System.Drawing.Size(135, 23);
            this.buttonCambiarResolucion.TabIndex = 23;
            this.buttonCambiarResolucion.Text = "Cambiar resolucion";
            this.buttonCambiarResolucion.UseVisualStyleBackColor = false;
            this.buttonCambiarResolucion.Click += new System.EventHandler(this.buttonCambiarResolucion_Click);
            // 
            // textBoxNumX
            // 
            this.textBoxNumX.Location = new System.Drawing.Point(31, 14);
            this.textBoxNumX.Name = "textBoxNumX";
            this.textBoxNumX.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumX.TabIndex = 24;
            // 
            // textBoxNumY
            // 
            this.textBoxNumY.Location = new System.Drawing.Point(164, 13);
            this.textBoxNumY.Name = "textBoxNumY";
            this.textBoxNumY.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumY.TabIndex = 25;
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.buttonExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExaminar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExaminar.ForeColor = System.Drawing.Color.Black;
            this.buttonExaminar.Location = new System.Drawing.Point(170, 159);
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size(75, 23);
            this.buttonExaminar.TabIndex = 26;
            this.buttonExaminar.Text = "Examinar";
            this.buttonExaminar.UseVisualStyleBackColor = false;
            this.buttonExaminar.Click += new System.EventHandler(this.buttonExaminar_Click);
            // 
            // comboBoxResoluciones
            // 
            this.comboBoxResoluciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResoluciones.FormattingEnabled = true;
            this.comboBoxResoluciones.Items.AddRange(new object[] {
            "1920x1080",
            "1768x992",
            "1680x1050",
            "1600x1024",
            "1600x900",
            "1440x900",
            "1400x1050",
            "1366x768",
            "1360x768",
            "1280x1024",
            "1280x720",
            "800x600"});
            this.comboBoxResoluciones.Location = new System.Drawing.Point(215, 28);
            this.comboBoxResoluciones.Name = "comboBoxResoluciones";
            this.comboBoxResoluciones.Size = new System.Drawing.Size(156, 24);
            this.comboBoxResoluciones.TabIndex = 27;
            // 
            // labelSeleccioneResolucion
            // 
            this.labelSeleccioneResolucion.AutoSize = true;
            this.labelSeleccioneResolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSeleccioneResolucion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccioneResolucion.ForeColor = System.Drawing.Color.White;
            this.labelSeleccioneResolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSeleccioneResolucion.Location = new System.Drawing.Point(32, 31);
            this.labelSeleccioneResolucion.Name = "labelSeleccioneResolucion";
            this.labelSeleccioneResolucion.Size = new System.Drawing.Size(179, 17);
            this.labelSeleccioneResolucion.TabIndex = 28;
            this.labelSeleccioneResolucion.Text = "Seleecione una resolucion";
            this.labelSeleccioneResolucion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelResX
            // 
            this.labelResX.AutoSize = true;
            this.labelResX.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResX.ForeColor = System.Drawing.Color.White;
            this.labelResX.Location = new System.Drawing.Point(6, 15);
            this.labelResX.Name = "labelResX";
            this.labelResX.Size = new System.Drawing.Size(22, 18);
            this.labelResX.TabIndex = 29;
            this.labelResX.Text = "X:";
            // 
            // labelResY
            // 
            this.labelResY.AutoSize = true;
            this.labelResY.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResY.ForeColor = System.Drawing.Color.White;
            this.labelResY.Location = new System.Drawing.Point(137, 16);
            this.labelResY.Name = "labelResY";
            this.labelResY.Size = new System.Drawing.Size(21, 18);
            this.labelResY.TabIndex = 30;
            this.labelResY.Text = "Y:";
            // 
            // groupBoxPersonalizada
            // 
            this.groupBoxPersonalizada.Controls.Add(this.labelResX);
            this.groupBoxPersonalizada.Controls.Add(this.labelResY);
            this.groupBoxPersonalizada.Controls.Add(this.textBoxNumX);
            this.groupBoxPersonalizada.Controls.Add(this.textBoxNumY);
            this.groupBoxPersonalizada.Enabled = false;
            this.groupBoxPersonalizada.Location = new System.Drawing.Point(37, 79);
            this.groupBoxPersonalizada.Name = "groupBoxPersonalizada";
            this.groupBoxPersonalizada.Size = new System.Drawing.Size(270, 45);
            this.groupBoxPersonalizada.TabIndex = 32;
            this.groupBoxPersonalizada.TabStop = false;
            // 
            // groupBoxResolucion
            // 
            this.groupBoxResolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.groupBoxResolucion.Controls.Add(this.panelUser);
            this.groupBoxResolucion.Controls.Add(this.textBoxNombreOut);
            this.groupBoxResolucion.Controls.Add(this.labelNomConver);
            this.groupBoxResolucion.Controls.Add(this.label1);
            this.groupBoxResolucion.Controls.Add(this.siticoneOSToggleSwithResolucionPersonalizada);
            this.groupBoxResolucion.Controls.Add(this.labelCarpertaSeleccionada);
            this.groupBoxResolucion.Controls.Add(this.labelSeleccioneResolucion);
            this.groupBoxResolucion.Controls.Add(this.comboBoxResoluciones);
            this.groupBoxResolucion.Controls.Add(this.buttonCambiarResolucion);
            this.groupBoxResolucion.Controls.Add(this.buttonExaminar);
            this.groupBoxResolucion.Controls.Add(this.groupBoxPersonalizada);
            this.groupBoxResolucion.Controls.Add(this.labelCarpetaDestino);
            this.groupBoxResolucion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.groupBoxResolucion.Location = new System.Drawing.Point(46, 24);
            this.groupBoxResolucion.Name = "groupBoxResolucion";
            this.groupBoxResolucion.Size = new System.Drawing.Size(502, 235);
            this.groupBoxResolucion.TabIndex = 33;
            this.groupBoxResolucion.TabStop = false;
            this.groupBoxResolucion.Text = "Resolucion";
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.White;
            this.panelUser.Location = new System.Drawing.Point(235, 150);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(139, 2);
            this.panelUser.TabIndex = 39;
            // 
            // textBoxNombreOut
            // 
            this.textBoxNombreOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.textBoxNombreOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNombreOut.ForeColor = System.Drawing.Color.White;
            this.textBoxNombreOut.Location = new System.Drawing.Point(238, 134);
            this.textBoxNombreOut.Name = "textBoxNombreOut";
            this.textBoxNombreOut.Size = new System.Drawing.Size(137, 15);
            this.textBoxNombreOut.TabIndex = 38;
            // 
            // labelNomConver
            // 
            this.labelNomConver.AutoSize = true;
            this.labelNomConver.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomConver.ForeColor = System.Drawing.Color.White;
            this.labelNomConver.Location = new System.Drawing.Point(32, 134);
            this.labelNomConver.Name = "labelNomConver";
            this.labelNomConver.Size = new System.Drawing.Size(209, 17);
            this.labelNomConver.TabIndex = 37;
            this.labelNomConver.Text = "Nombre del archivo convertido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Resolucion Personalizada";
            // 
            // siticoneOSToggleSwithResolucionPersonalizada
            // 
            this.siticoneOSToggleSwithResolucionPersonalizada.Location = new System.Drawing.Point(215, 58);
            this.siticoneOSToggleSwithResolucionPersonalizada.Name = "siticoneOSToggleSwithResolucionPersonalizada";
            this.siticoneOSToggleSwithResolucionPersonalizada.Size = new System.Drawing.Size(38, 22);
            this.siticoneOSToggleSwithResolucionPersonalizada.TabIndex = 35;
            this.siticoneOSToggleSwithResolucionPersonalizada.Text = "siticoneOSToggleSwithResolucionPersonalizada";
            this.siticoneOSToggleSwithResolucionPersonalizada.CheckedChanged += new System.EventHandler(this.siticoneOSToggleSwithResolucionPersonalizada_CheckedChanged);
            // 
            // labelCarpertaSeleccionada
            // 
            this.labelCarpertaSeleccionada.AutoSize = true;
            this.labelCarpertaSeleccionada.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarpertaSeleccionada.Location = new System.Drawing.Point(248, 162);
            this.labelCarpertaSeleccionada.Name = "labelCarpertaSeleccionada";
            this.labelCarpertaSeleccionada.Size = new System.Drawing.Size(0, 15);
            this.labelCarpertaSeleccionada.TabIndex = 33;
            // 
            // labelCarpetaDestino
            // 
            this.labelCarpetaDestino.AutoSize = true;
            this.labelCarpetaDestino.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarpetaDestino.ForeColor = System.Drawing.Color.White;
            this.labelCarpetaDestino.Location = new System.Drawing.Point(34, 162);
            this.labelCarpetaDestino.Name = "labelCarpetaDestino";
            this.labelCarpetaDestino.Size = new System.Drawing.Size(139, 17);
            this.labelCarpetaDestino.TabIndex = 34;
            this.labelCarpetaDestino.Text = "Seleccionar Destino";
            // 
            // FormResolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(571, 288);
            this.Controls.Add(this.groupBoxResolucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResolucion";
            this.groupBoxPersonalizada.ResumeLayout(false);
            this.groupBoxPersonalizada.PerformLayout();
            this.groupBoxResolucion.ResumeLayout(false);
            this.groupBoxResolucion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCambiarResolucion;
        private System.Windows.Forms.TextBox textBoxNumX;
        private System.Windows.Forms.TextBox textBoxNumY;
        private System.Windows.Forms.Button buttonExaminar;
        private System.Windows.Forms.ComboBox comboBoxResoluciones;
        private System.Windows.Forms.Label labelSeleccioneResolucion;
        private System.Windows.Forms.Label labelResX;
        private System.Windows.Forms.Label labelResY;
        private System.Windows.Forms.GroupBox groupBoxPersonalizada;
        private System.Windows.Forms.GroupBox groupBoxResolucion;
        private System.Windows.Forms.Label labelCarpertaSeleccionada;
        private System.Windows.Forms.Label labelCarpetaDestino;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith siticoneOSToggleSwithResolucionPersonalizada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.TextBox textBoxNombreOut;
        private System.Windows.Forms.Label labelNomConver;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogCarpetaSeleccionada;
    }
}