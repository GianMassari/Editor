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
    public partial class FormReproductor : Form
    {
        private string rutaArchivo;
        private string url;
        public FormReproductor(string rutaArchivo)
        {
            InitializeComponent();
            this.rutaArchivo = rutaArchivo;
            cargarVideo();
           
        }

        private void cargarVideo()
        {
            if (this.url==null)
            {
                this.url = this.rutaArchivo;
                axWindowsMediaPlayerReproductor.URL = url;
               
            }
            
        }
        public void cerrarForm()
        {
            this.Close();
        }
    }
}
