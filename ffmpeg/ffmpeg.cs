using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.FFMPEG
{
   static class ffmpeg
    {
       /*public static List<ProcessStartInfo> processes = new List<ProcessStartInfo>();*/

        //CAMBIAR FORMATOS
        public static void correrFormatos(string rutaSeleccionada, string rutaCarpetaGuardar, string nombreOut, string formatoOut)
        {
            var output = rutaCarpetaGuardar + "\\" + nombreOut + formatoOut;
            /* ProcessStartInfo formato = new ProcessStartInfo();
             formato.FileName = "cmd.exe";
             formato.WindowStyle = ProcessWindowStyle.Hidden;
             formato.Arguments = "/c ffmpeg -i " + rutaSeleccionada + " -qscale 0 " + output;
             Process.Start(formato);*/
            var comando = "ffmpeg -i \"" + rutaSeleccionada + "\" -qscale 0 " + "\""+ output + "\"";
            Console.WriteLine(comando);
            correrComando(comando);
            
        }
       
        //EXTRAER EL AUDIO COMO MP3
        public static void extraerAudio(string rutaSeleccionada, string rutaCarpetaGuardar)
        {
            /*ProcessStartInfo formato = new ProcessStartInfo();
            formato.FileName = "cmd.exe";
            formato.WindowStyle = ProcessWindowStyle.Hidden;
            formato.Arguments = "/c ffmpeg -i " + rutaSeleccionada + " -vn " + rutaCarpetaGuardar;
            Process.Start(formato);*/
            var comando = "ffmpeg -i \"" + rutaSeleccionada + "\" -vn \"" + rutaCarpetaGuardar + "\"";
            correrComando(comando);


        }

      
        //CAMBIAR RESOLUCION
        public static void cambiarResolucion(string input,string rutaCarpeta,string nombreOut,int x,int y)
        {

            /*ProcessStartInfo resolucion = new ProcessStartInfo();
            resolucion.FileName = "cmd.exe";
            resolucion.WindowStyle = ProcessWindowStyle.Hidden;
            resolucion.Arguments = "/c ffmpeg -i " + input + " -s " + x +"x"+ y + " -c:a copy "+ output;
            Process.Start(resolucion);*/
            var output = rutaCarpeta + "\\" + nombreOut;
            var comando= "ffmpeg -i \"" + input + "\" -s " + x +"x"+ y + " -c:a copy \""+ output+"\"";
            correrComando(comando);
        }

        //EXTRAER IMAGENES
        public static void extraerImagenes(string input,double cantFrames,string comienzo,string rutaCarpetaGuardar,string nombreOut,string formato)
        {
            
            /*
                        ProcessStartInfo resolucion = new ProcessStartInfo();
                        resolucion.FileName = "cmd.exe";
                        resolucion.WindowStyle = ProcessWindowStyle.Hidden;
                        resolucion.Arguments = "/c ffmpeg -i "+ input + " -r "+cantFrames+" -ss "+ comienzo + " -f image2 "+ output;
                        Process.Start(resolucion);*/

            var output = rutaCarpetaGuardar + "\\" + nombreOut + "-%2d" + formato;
            var comando = "ffmpeg -i \"" + input + "\" -r " + cantFrames + " -ss " + comienzo + " -f image2 \"" + output + "\"";
            correrComando(comando);
        }

        //REMOVER AUDIO DE UN VIDEO
        public static void removerAudio(string input , string output)
        {
            var comando = "ffmpeg -i \"" + input+ "\" -c copy -an \""+ output + "\"";
            correrComando(comando);
        }

        

        //CORRE EL COMNADO EN EL CMD
        private static void correrComando(string comando)
        {
            ProcessStartInfo comandoCmd = new ProcessStartInfo();
            comandoCmd.FileName = "cmd.exe";
            comandoCmd.WindowStyle = ProcessWindowStyle.Hidden;
            comandoCmd.Arguments = "/c " + comando;
            Process ieProcess= Process.Start(comandoCmd);
            ieProcess.WaitForExit();
           

            /*  processes.Add(comandoCmd);*/
        }

        /*public static void matarProcesos()
        {
            foreach (ProcessStartInfo process in processes)
                process.Kill();
        }*/
    }
}
