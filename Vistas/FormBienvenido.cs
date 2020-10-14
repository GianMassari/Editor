using Editor.DAOs;
using Editor.FFMPEG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class FormBienvenido : Form
    {
         private int contClickUser=0;
        private int contClickPassword = 0;

        public FormBienvenido()
        {
            InitializeComponent();
            this.AcceptButton = buttonIngresar;
         
        }
        //METODO PARA LIMPIAR LOS CAMPOS
        public void limpiarCampos()
        {
            textBoxUser.Clear();
            textBoxPassword.Clear();

        }

        //EVENTO BOTON INGRESAR
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            var username = textBoxUser.Text;
            var password = textBoxPassword.Text;
            if (UsuariosDAO.existeUsuario(username, password))
            {
                var formApp = new FormApp(this, username);
                formApp.Show();
                this.Hide();
                resetearForm();
            }
            else
            {
                labelEstado.Text = "El usuario o contraseña son incorrectos";
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarCampos();
            }

        }

        //PARA RESETEAR EL FORM
        private void resetearForm()
        {
            textBoxUser.Text = "Usuario";
            textBoxPassword.Text = "Contraseña";
            this.contClickPassword = 0;
            this.contClickUser = 0;
            labelEstado.Text = "";
            pictureBoxUser.Image = Properties.Resources.man1;
            pictureBoxPassword.Image = Properties.Resources._lock;
            panelPassword.BackColor = Color.White;
            panelUser.BackColor = Color.White;

        }

        //EVENTO CLICK EN TEXT
        private void textBoxUser_Click(object sender, EventArgs e)
        {
            this.contClickUser++;

            if (this.contClickUser == 1)
            {
                textBoxUser.Clear();
            }
            
            pictureBoxUser.Image = Properties.Resources.manv2;
            panelUser.BackColor = Color.FromArgb(74, 197, 255);

            pictureBoxPassword.Image = Properties.Resources._lock;
            panelPassword.BackColor = Color.White;
        }

        //EVENTO CLICK EN TEXT
        private void textBoxContrasenia_Click(object sender, EventArgs e)
        {

            this.contClickPassword++;

            if (this.contClickPassword == 1)
            {
                textBoxPassword.Clear();
            }

            pictureBoxUser.Image = Properties.Resources.man1;
            panelUser.BackColor = Color.White;

            pictureBoxPassword.Image = Properties.Resources.lockv2;
            panelPassword.BackColor = Color.FromArgb(74, 197, 255);

        }

        //BOTON X
        private void labelBotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //BOTON MINIMIZAR
        private void labelBotonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //CODIGO QUE ENCONTRE EN GOOGLE PARA PODER ARRASTRAR LA VENTANA DESDE UN PANEL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panelArrastrarVentana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
    }
    
