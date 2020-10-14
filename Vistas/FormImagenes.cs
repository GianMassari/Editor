using Editor.FFMPEG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class FormImagenes : Form
    {
        private FormApp formApp = new FormApp();
        private string rutaCarpetaGuardar;
        private string rutaArchivoSeleccionado;

    
        
        public FormImagenes(string rutaArchivo)
        {
            this.rutaArchivoSeleccionado = rutaArchivo;
            InitializeComponent();
        }


        private void buttonExaminar_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialogCarpeta.ShowDialog() == DialogResult.OK)
            {
                this.rutaCarpetaGuardar = folderBrowserDialogCarpeta.SelectedPath;
                labelCarpetaSeleccionada.Text = this.rutaCarpetaGuardar;
            }
        }

        
        private void buttonExtraerImagenes_Click(object sender, EventArgs e)
        {
            if (this.rutaCarpetaGuardar !=null && comboBoxFormatos.Text !=null && textBoxNombreOut.Text !=null)
            {
                var nombreOut = textBoxNombreOut.Text;
                var formatoOut = comboBoxFormatos.Text;
                var tiempo = "00:00";
                var cantFrames = (double)numericUpDownXFrames.Value;

                if (siticoneToggleSwitchxTiempo.Checked==true)
                {
                    tiempo = textBoxTiempoCustom.Text;
                }
                
                    var nombreNew = nombreOut.Trim();
                    var nombreProcesado = nombreNew.Replace(" ", "_");
                 
                ffmpeg.extraerImagenes(this.rutaArchivoSeleccionado, cantFrames , tiempo, this.rutaCarpetaGuardar,nombreProcesado, formatoOut);
                formApp.mostarEstado("Se extrajeron las imagenes con exito", "Completado con exito", true);
                this.Close();
            }
            else
            {
                formApp.mostarEstado("Ingrese los campos requeridos", "Campos incompletos", false);   
            }
        }

        //EVENTO DEL SWITCH
        private void siticoneToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.siticoneToggleSwitchxTiempo.Checked == true)
            {
                this.textBoxTiempoCustom.Visible = true;
              
            }
            else
            {
                this.textBoxTiempoCustom.Visible = false;
            
            }
            
        }

        //EVENTO PARA CUANDO SE HACE CLICK EN EL TEXTBOX SE BORRA EL TEXTO
        private void textBoxTiempoCustom_Click(object sender, EventArgs e)
        {
            textBoxTiempoCustom.Clear();
        }
    }
}
