using Editor.FFMPEG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class FormApp : Form
    {
        private Form formAnterior;

        
        //ATRIBUTOS

        private string rutaArchivoSeleccionado="";
        private string rutaArchivoGuardarAudio;
        private string rutaArchivoRemoverAudio;

        //METODOS
        public FormApp(Form formBienvienido ,string user)
        {
            this.formAnterior = formBienvienido;
            InitializeComponent();
            this.BackColor = Color.FromArgb(50, 130, 184);
            ToolStripMenuItemCuenta.Text = user;
            openFileDialogNewArchivo.Filter = "Video mp4 |*.mp4|Video mkv (*.mkv)|*.mkv|Video avi (*.avi)|*.avi|Video mpeg (*.mpeg)|*.mpeg|Video flv (*.flv)|*.flv";
        }
        public FormApp()
        {
            
        }

        //BOTON CARGAR ARCHIVO
        private void toolStripMenuItemAbrirArchivo_Click(object sender, EventArgs e)
        {
            
            if (openFileDialogNewArchivo.ShowDialog() == DialogResult.OK)
            {
                
                this.rutaArchivoSeleccionado = openFileDialogNewArchivo.FileName;
                labelNombreArchivo.Text =  openFileDialogNewArchivo.SafeFileName;
                panelBotones.Enabled=true;
                panelBotones.Visible = true;
         
            }
        }
      //BOTON EXTRAER AUDIO
        private void buttonExAudio_Click(object sender, EventArgs e)
        {
            if (rutaArchivoSeleccionado.Length != 0)
            {
                
                activarPanel(this.panelAudio);

                if (saveFileDialogGuardarMp3.ShowDialog() == DialogResult.OK)
                {
                    this.rutaArchivoGuardarAudio = saveFileDialogGuardarMp3.FileName;
                }

                var input = rutaArchivoSeleccionado;
                var output = rutaArchivoGuardarAudio;

                ffmpeg.extraerAudio(input, output);
            }
            else
            {
                MessageBox.Show("Primero selecciona el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
        //BOTON CAMBIAR RESOLUCION
        private void buttonResolucion_Click(object sender, EventArgs e)
        {
            if (rutaArchivoSeleccionado.Length != 0)
            {
               
                activarPanel(this.panelResolucion);
                FormResolucion formResolucion = new FormResolucion(this.rutaArchivoSeleccionado);
                abrirFromEnPanel(formResolucion);
            }
            else
            {
                MessageBox.Show("Primero selecciona el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        //BOTON EXTRAER IMAGENES
        private void buttonExtraerImagenes_Click(object sender, EventArgs e)
        {
            if (rutaArchivoSeleccionado.Length != 0)
            {
                activarPanel(this.panelImagenes);
                FormImagenes formImagenes = new FormImagenes(this.rutaArchivoSeleccionado);
                abrirFromEnPanel(formImagenes);

            }
            else
            {
                MessageBox.Show("Primero selecciona el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BOTON CONVERTIR A VARIOS FORMATOS
        private void ButtonFormatos_Click(object sender, EventArgs e)
        {
        
            if (rutaArchivoSeleccionado.Length != 0)
            {
                activarPanel(this.panelConvertir);
                var formFormatos = new FormFormatos(this.rutaArchivoSeleccionado);
                abrirFromEnPanel(formFormatos);
                
            }
            else
            {
                MessageBox.Show("Primero selecciona el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //BOTON PLAY
        private void buttonPlay_Click(object sender, EventArgs e)
        {

            if (rutaArchivoSeleccionado.Length != 0)
            {
                activarPanel(this.panelVideo);
                var reproductor = new FormReproductor(this.rutaArchivoSeleccionado);
                abrirFromEnPanel(reproductor);
               
               
            }
            else
            {
                MessageBox.Show("Primero selecciona el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //BOTON REMOVER AUDIO
        private void buttonRemoverAudio_Click(object sender, EventArgs e)
        {
            if (rutaArchivoSeleccionado.Length != 0)
            {
                activarPanel(this.panelRemoverAudio);
                if (saveFileDialogRemoverAudio.ShowDialog() == DialogResult.OK)
                {
                    this.rutaArchivoRemoverAudio = saveFileDialogRemoverAudio.FileName;
                }

                var formatoInicial=rutaArchivoSeleccionado.Split('.').Last();
                var nombreProcesado = procesarNombre(rutaArchivoRemoverAudio + "." + formatoInicial);
                ffmpeg.removerAudio(rutaArchivoSeleccionado, nombreProcesado);
            
            }
            else
            {
                MessageBox.Show("Primero selecciona el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //CERRAR SESION
        private void ToolStripMenuItemCerrarSesion_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            this.Close();
        }

        //CHECK PARA QUE NO SE SUPERPONGAN 2 FORM
        private void abrirFromEnPanel(Form formAMostrar)
        {
            if (this.panelForm.Controls.Count==0)
            {
                funcionMostarPanel(formAMostrar);
            }
            else
            {
                this.panelForm.Controls.RemoveAt(0);
                funcionMostarPanel(formAMostrar);

            }
        }

        

        //FUNCION PARA MOSTRAR UN FORM EN EL PANEL
        private void funcionMostarPanel(Form formAMostrar)
        {
            Form formPanel = formAMostrar as Form;
            formPanel.TopLevel = false;
            formPanel.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(formPanel);
            this.panelForm.Tag = formPanel;
            formPanel.Show();
        }
        //PARA MOSTAR MENSAJES  
        public void mostarEstado(string mensaje,string titulo,Boolean estado)
        {
            if (estado)
            {
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        //LE SACA LOS ESPACIOS AL NOMBRE
        private string procesarNombre(string nombre)
        {
            var nombreNew = nombre.Trim();
            return nombreNew;
        }


        private void activarPanel(Panel panelActivar)
        {
            this.panelAudio.Visible = false;
            this.panelConvertir.Visible = false;
            this.panelResolucion.Visible = false;
            this.panelImagenes.Visible = false;
            this.panelVideo.Visible = false;
            this.panelRemoverAudio.Visible = false;
            panelActivar.Visible = true;
        }

        //SI SE APRETA LA X PARA CERRAR SE PREGUNTA SI QUIERE CERRAR
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            switch (MessageBox.Show(this, "Estas seguro/a que quiere cerrar la aplicacion?", "Cerrando", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    e.Cancel = false;
                    formAnterior.Close();
                    break;
            }
        }

       
    }
}
