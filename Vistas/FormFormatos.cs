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
    public partial class FormFormatos : Form
    {
        private FormApp formApp = new FormApp();
        private string rutaArchivoSeleccionado;
        private string rutaCarpetaGuardar="";
        private string nombreOut="";

        public FormFormatos(string rutaArchivo)
        {
            this.rutaArchivoSeleccionado = rutaArchivo;
            InitializeComponent();
            
        }
        
        private void buttonFormato_Click(object sender, EventArgs e)
        {
            nombreOut = textBoxNombreOut.Text;
            if (nombreOut.Length == 0 || rutaCarpetaGuardar.Length==0)
            {
                formApp.mostarEstado("Ingrese el nombre del archivo y/o la ruta de destino", "Error", false);
            }
            else if (checkBoxMp4.Checked || checkBoxMp3.Checked || checkBoxMpeg.Checked || checkBoxAvi.Checked || checkBoxFlv.Checked)
            {

                    funcionCheck(checkBoxMp4 ,".mp4");
                    funcionCheck(checkBoxMp3 ,".mp3");
                    funcionCheck(checkBoxMpeg ,".mpeg");
                    funcionCheck(checkBoxAvi ,".avi");
                    funcionCheck(checkBoxFlv, ".flv");

                formApp.mostarEstado("La conversion se realizo con exito", "Finalizado", true);
                this.Close();
            }
            else
            {
                formApp.mostarEstado("Seleccione al menos un opcion", "Campos insuficientes", false);
            }
           
        }
        //FUNCION PARA CORRER EL QUE ESTA SELECCIONADO
        private void funcionCheck(CheckBox boton , string formato)
        {
            if (boton.Checked)
            {
                
                    var nombreNew = nombreOut.Trim();
                    var nombreProcesado = nombreNew.Replace(" ", "_");
                ffmpeg.correrFormatos(rutaArchivoSeleccionado,rutaCarpetaGuardar,nombreProcesado,formato);
            }
        }

       

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogCarpeta.ShowDialog() == DialogResult.OK)
            {
                this.rutaCarpetaGuardar = folderBrowserDialogCarpeta.SelectedPath;
                labelCarpetaSeleccionada.Text = this.rutaCarpetaGuardar;
            }
        }

        //BOTON X PARA CERRAR
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
