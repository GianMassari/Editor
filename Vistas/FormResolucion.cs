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
using System.Windows.Forms.VisualStyles;

namespace Editor
{



    public partial class FormResolucion : Form
    {


        private FormApp formPrincipal = new FormApp();
        private string rutaArchivoNuevo="";
        private string rutaArchivoSeleccionado;
        

        public FormResolucion(string rutaArchivoSeleccionado)
        {

            this.rutaArchivoSeleccionado = rutaArchivoSeleccionado;
            InitializeComponent();
        }


        private void buttonCambiarResolucion_Click(object sender, EventArgs e)
        {
            if (checkPersonalizada() == true && textBoxNumX.TextLength == 0 || checkPersonalizada() == true && textBoxNumY.TextLength == 0 || checkPersonalizada() == false && comboBoxResoluciones.Text.Length == 0 || checkCampos())
            {
                formPrincipal.mostarEstado("Ingresa la resolucion y el nombre deseado", "Campos insuficientes", false);
            }
            else
            {
                
                try
                {
                    var x = int.Parse(obtenerX());
                    var y = int.Parse(obtenerY());
                    var nombreOut = procesarNombre(textBoxNombreOut.Text) + cortarFormato(this.rutaArchivoSeleccionado);
                    ffmpeg.cambiarResolucion(rutaArchivoSeleccionado, rutaArchivoNuevo,nombreOut, x, y);
                    formPrincipal.mostarEstado("Se cambio la resolucion con exito", "Exito", true);
                    this.Close();
                }
                catch (Exception exc)
                {
                    formPrincipal.mostarEstado("Ingresa solo numeros\nPor Ejemplo X:1920 Y:1080", "Resolucion Personalizada", false);
                }
            }


        }
        //METODO PARA SACAR ESPACIOS
        private string procesarNombre(string nombre)
        {
            var nombreNew = nombre.Trim();
            var nombreProcesado = nombreNew.Replace(" ", "_");
            return nombreProcesado;
        }


        private string obtenerX()
        {
            if (checkPersonalizada())
            {
                return textBoxNumX.Text;
            }
            else
            {
                var resolucionExtraida = comboBoxResoluciones.Text;
                var numeros = resolucionExtraida.Split('x');
                return numeros[0];
            }
        }

        private string obtenerY()
        {
            if (checkPersonalizada())
            {
                return textBoxNumY.Text;
            }
            else
            {
                var resolucionExtraida = comboBoxResoluciones.Text;
                var numeros = resolucionExtraida.Split('x');
                return numeros[1];
            }
        }

        //METODO PARA CHECKEAR SI EL SWITCH DE RESOLUCION PERSONALIZADO ESTA SELECCIONADO
        private Boolean checkPersonalizada()
        {
            if (siticoneOSToggleSwithResolucionPersonalizada.Checked == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        
        private void guardarRuta()
        {
            if (folderBrowserDialogCarpetaSeleccionada.ShowDialog() == DialogResult.OK)
            {
                this.rutaArchivoNuevo = folderBrowserDialogCarpetaSeleccionada.SelectedPath;
                labelCarpertaSeleccionada.Text = folderBrowserDialogCarpetaSeleccionada.SelectedPath;

            }
        }

        //CHECKEA SI ESTAN VACIOS LOS CAMPOS 
        private Boolean checkCampos()
        {
            return textBoxNombreOut.TextLength == 0 || !(this.rutaArchivoNuevo.Length >0);
        }

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            guardarRuta();
           
        }

        //OBTENER EL FORMATO DEL ARCHIVO PRINCIPAL
        private static string cortarFormato(string archivo)
        {
            return "." + archivo.Split('.').Last();
        }

        private void siticoneOSToggleSwithResolucionPersonalizada_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneOSToggleSwithResolucionPersonalizada.Checked == true)
            {
                comboBoxResoluciones.Enabled = false;
                groupBoxPersonalizada.Enabled = true;
                


            }
            else
            {
                comboBoxResoluciones.Enabled = true;
                groupBoxPersonalizada.Enabled = false;
                

            }
        }

       
    }
}
