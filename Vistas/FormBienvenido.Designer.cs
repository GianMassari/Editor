namespace Editor
{
    partial class FormBienvenido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBienvenido));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelBotonCerrar = new System.Windows.Forms.Label();
            this.labelBotonMinimizar = new System.Windows.Forms.Label();
            this.panelArrastrarVentana = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(98, 62);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(529, 37);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Bienvenido a Simplex video tools";
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxUser.Location = new System.Drawing.Point(68, 76);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(212, 15);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.TabStop = false;
            this.textBoxUser.Text = "Usuario";
            this.textBoxUser.Click += new System.EventHandler(this.textBoxUser_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Location = new System.Drawing.Point(68, 156);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(146, 15);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.Text = "Contraseña";
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxContrasenia_Click);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.Location = new System.Drawing.Point(84, 212);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(142, 34);
            this.buttonIngresar.TabIndex = 4;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.ForeColor = System.Drawing.Color.Red;
            this.labelEstado.Location = new System.Drawing.Point(35, 33);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(0, 16);
            this.labelEstado.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelPassword);
            this.groupBox1.Controls.Add(this.pictureBoxPassword);
            this.groupBox1.Controls.Add(this.panelUser);
            this.groupBox1.Controls.Add(this.pictureBoxUser);
            this.groupBox1.Controls.Add(this.labelEstado);
            this.groupBox1.Controls.Add(this.buttonIngresar);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxUser);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(210, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.White;
            this.panelPassword.Location = new System.Drawing.Point(38, 177);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(242, 2);
            this.panelPassword.TabIndex = 8;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::Editor.Properties.Resources._lock;
            this.pictureBoxPassword.Location = new System.Drawing.Point(38, 149);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPassword.TabIndex = 7;
            this.pictureBoxPassword.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.White;
            this.panelUser.Location = new System.Drawing.Point(38, 103);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(242, 2);
            this.panelUser.TabIndex = 2;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::Editor.Properties.Resources.man1;
            this.pictureBoxUser.Location = new System.Drawing.Point(38, 73);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxUser.TabIndex = 2;
            this.pictureBoxUser.TabStop = false;
            // 
            // labelBotonCerrar
            // 
            this.labelBotonCerrar.AutoSize = true;
            this.labelBotonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBotonCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBotonCerrar.Location = new System.Drawing.Point(694, 9);
            this.labelBotonCerrar.Name = "labelBotonCerrar";
            this.labelBotonCerrar.Size = new System.Drawing.Size(20, 20);
            this.labelBotonCerrar.TabIndex = 2;
            this.labelBotonCerrar.Text = "X";
            this.labelBotonCerrar.Click += new System.EventHandler(this.labelBotonCerrar_Click);
            // 
            // labelBotonMinimizar
            // 
            this.labelBotonMinimizar.AutoSize = true;
            this.labelBotonMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBotonMinimizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBotonMinimizar.Location = new System.Drawing.Point(665, 0);
            this.labelBotonMinimizar.Name = "labelBotonMinimizar";
            this.labelBotonMinimizar.Size = new System.Drawing.Size(23, 31);
            this.labelBotonMinimizar.TabIndex = 3;
            this.labelBotonMinimizar.Text = "-";
            this.labelBotonMinimizar.Click += new System.EventHandler(this.labelBotonMinimizar_Click);
            // 
            // panelArrastrarVentana
            // 
            this.panelArrastrarVentana.Location = new System.Drawing.Point(2, 0);
            this.panelArrastrarVentana.Name = "panelArrastrarVentana";
            this.panelArrastrarVentana.Size = new System.Drawing.Size(725, 38);
            this.panelArrastrarVentana.TabIndex = 4;
            this.panelArrastrarVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelArrastrarVentana_MouseDown);
            // 
            // FormBienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.labelBotonMinimizar);
            this.Controls.Add(this.labelBotonCerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panelArrastrarVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Label labelBotonCerrar;
        private System.Windows.Forms.Label labelBotonMinimizar;
        private System.Windows.Forms.Panel panelArrastrarVentana;
    }
}

