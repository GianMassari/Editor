namespace Editor
{
    partial class FormImagenes
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
            this.buttonExtraerImagenes = new System.Windows.Forms.Button();
            this.textBoxTiempoCustom = new System.Windows.Forms.TextBox();
            this.textBoxNombreOut = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonExaminar = new System.Windows.Forms.Button();
            this.labelCarpetaSeleccionada = new System.Windows.Forms.Label();
            this.comboBoxFormatos = new System.Windows.Forms.ComboBox();
            this.siticoneToggleSwitchxTiempo = new Siticone.UI.WinForms.SiticoneToggleSwitch();
            this.labelTiempoCustom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownXFrames = new System.Windows.Forms.NumericUpDown();
            this.panelNombreImagenes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCantFrames = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXFrames)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExtraerImagenes
            // 
            this.buttonExtraerImagenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.buttonExtraerImagenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtraerImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonExtraerImagenes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExtraerImagenes.Location = new System.Drawing.Point(186, 217);
            this.buttonExtraerImagenes.Name = "buttonExtraerImagenes";
            this.buttonExtraerImagenes.Size = new System.Drawing.Size(137, 28);
            this.buttonExtraerImagenes.TabIndex = 0;
            this.buttonExtraerImagenes.Text = "Extraer Imagenes";
            this.buttonExtraerImagenes.UseVisualStyleBackColor = false;
            this.buttonExtraerImagenes.Click += new System.EventHandler(this.buttonExtraerImagenes_Click);
            // 
            // textBoxTiempoCustom
            // 
            this.textBoxTiempoCustom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTiempoCustom.Location = new System.Drawing.Point(307, 65);
            this.textBoxTiempoCustom.Name = "textBoxTiempoCustom";
            this.textBoxTiempoCustom.Size = new System.Drawing.Size(119, 25);
            this.textBoxTiempoCustom.TabIndex = 2;
            this.textBoxTiempoCustom.Text = "Ejemplo \"01:45\"";
            this.textBoxTiempoCustom.Visible = false;
            this.textBoxTiempoCustom.Click += new System.EventHandler(this.textBoxTiempoCustom_Click);
            // 
            // textBoxNombreOut
            // 
            this.textBoxNombreOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.textBoxNombreOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreOut.ForeColor = System.Drawing.Color.White;
            this.textBoxNombreOut.Location = new System.Drawing.Point(192, 141);
            this.textBoxNombreOut.Name = "textBoxNombreOut";
            this.textBoxNombreOut.Size = new System.Drawing.Size(132, 15);
            this.textBoxNombreOut.TabIndex = 3;
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.buttonExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonExaminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExaminar.Location = new System.Drawing.Point(216, 183);
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size(75, 28);
            this.buttonExaminar.TabIndex = 14;
            this.buttonExaminar.Text = "Examinar";
            this.buttonExaminar.UseVisualStyleBackColor = false;
            this.buttonExaminar.Click += new System.EventHandler(this.buttonExaminar_Click);
            // 
            // labelCarpetaSeleccionada
            // 
            this.labelCarpetaSeleccionada.AutoSize = true;
            this.labelCarpetaSeleccionada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.labelCarpetaSeleccionada.Location = new System.Drawing.Point(339, 212);
            this.labelCarpetaSeleccionada.Name = "labelCarpetaSeleccionada";
            this.labelCarpetaSeleccionada.Size = new System.Drawing.Size(0, 13);
            this.labelCarpetaSeleccionada.TabIndex = 21;
            // 
            // comboBoxFormatos
            // 
            this.comboBoxFormatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormatos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormatos.FormattingEnabled = true;
            this.comboBoxFormatos.Items.AddRange(new object[] {
            ".jpeg",
            ".png"});
            this.comboBoxFormatos.Location = new System.Drawing.Point(21, 100);
            this.comboBoxFormatos.Name = "comboBoxFormatos";
            this.comboBoxFormatos.Size = new System.Drawing.Size(112, 24);
            this.comboBoxFormatos.TabIndex = 22;
            // 
            // siticoneToggleSwitchxTiempo
            // 
            this.siticoneToggleSwitchxTiempo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneToggleSwitchxTiempo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneToggleSwitchxTiempo.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.siticoneToggleSwitchxTiempo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneToggleSwitchxTiempo.CheckedState.Parent = this.siticoneToggleSwitchxTiempo;
            this.siticoneToggleSwitchxTiempo.Location = new System.Drawing.Point(499, 33);
            this.siticoneToggleSwitchxTiempo.Name = "siticoneToggleSwitchxTiempo";
            this.siticoneToggleSwitchxTiempo.ShadowDecoration.Parent = this.siticoneToggleSwitchxTiempo;
            this.siticoneToggleSwitchxTiempo.Size = new System.Drawing.Size(35, 20);
            this.siticoneToggleSwitchxTiempo.TabIndex = 23;
            this.siticoneToggleSwitchxTiempo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneToggleSwitchxTiempo.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneToggleSwitchxTiempo.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.siticoneToggleSwitchxTiempo.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneToggleSwitchxTiempo.UncheckedState.Parent = this.siticoneToggleSwitchxTiempo;
            this.siticoneToggleSwitchxTiempo.CheckedChanged += new System.EventHandler(this.siticoneToggleSwitch1_CheckedChanged);
            // 
            // labelTiempoCustom
            // 
            this.labelTiempoCustom.AutoSize = true;
            this.labelTiempoCustom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempoCustom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTiempoCustom.Location = new System.Drawing.Point(304, 35);
            this.labelTiempoCustom.Name = "labelTiempoCustom";
            this.labelTiempoCustom.Size = new System.Drawing.Size(196, 17);
            this.labelTiempoCustom.TabIndex = 24;
            this.labelTiempoCustom.Text = "Arrancar desde cierto tiempo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownXFrames);
            this.groupBox1.Controls.Add(this.panelNombreImagenes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelCantFrames);
            this.groupBox1.Controls.Add(this.siticoneToggleSwitchxTiempo);
            this.groupBox1.Controls.Add(this.buttonExtraerImagenes);
            this.groupBox1.Controls.Add(this.buttonExaminar);
            this.groupBox1.Controls.Add(this.labelTiempoCustom);
            this.groupBox1.Controls.Add(this.textBoxTiempoCustom);
            this.groupBox1.Controls.Add(this.textBoxNombreOut);
            this.groupBox1.Controls.Add(this.comboBoxFormatos);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(32, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 262);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extraer imagenes";
            // 
            // numericUpDownXFrames
            // 
            this.numericUpDownXFrames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.numericUpDownXFrames.DecimalPlaces = 1;
            this.numericUpDownXFrames.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownXFrames.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDownXFrames.Location = new System.Drawing.Point(154, 35);
            this.numericUpDownXFrames.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownXFrames.Name = "numericUpDownXFrames";
            this.numericUpDownXFrames.Size = new System.Drawing.Size(55, 22);
            this.numericUpDownXFrames.TabIndex = 30;
            this.numericUpDownXFrames.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelNombreImagenes
            // 
            this.panelNombreImagenes.BackColor = System.Drawing.Color.White;
            this.panelNombreImagenes.Location = new System.Drawing.Point(186, 161);
            this.panelNombreImagenes.Name = "panelNombreImagenes";
            this.panelNombreImagenes.Size = new System.Drawing.Size(139, 2);
            this.panelNombreImagenes.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Formato de las imagenes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre de las imagenes:";
            // 
            // labelCantFrames
            // 
            this.labelCantFrames.AutoSize = true;
            this.labelCantFrames.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantFrames.ForeColor = System.Drawing.Color.White;
            this.labelCantFrames.Location = new System.Drawing.Point(16, 37);
            this.labelCantFrames.Name = "labelCantFrames";
            this.labelCantFrames.Size = new System.Drawing.Size(141, 17);
            this.labelCantFrames.TabIndex = 25;
            this.labelCantFrames.Text = "Cada tantos frames:";
            // 
            // FormImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(592, 313);
            this.Controls.Add(this.labelCarpetaSeleccionada);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormImagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormImagenes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXFrames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExtraerImagenes;
        private System.Windows.Forms.TextBox textBoxTiempoCustom;
        private System.Windows.Forms.TextBox textBoxNombreOut;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogCarpeta;
        private System.Windows.Forms.Button buttonExaminar;
        private System.Windows.Forms.Label labelCarpetaSeleccionada;
        private System.Windows.Forms.ComboBox comboBoxFormatos;
        private Siticone.UI.WinForms.SiticoneToggleSwitch siticoneToggleSwitchxTiempo;
        private System.Windows.Forms.Label labelTiempoCustom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCantFrames;
        private System.Windows.Forms.Panel panelNombreImagenes;
        private System.Windows.Forms.NumericUpDown numericUpDownXFrames;
    }
}