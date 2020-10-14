using Editor.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.DAOs
{
    class UsuariosDAO
    {
       public static List<Usuario> listaUsuario = new List<Usuario>();
        public static void iniciar()
        {
            listaUsuario.Add(new Usuario("asd", "asd"));
            listaUsuario.Add(new Usuario("", ""));
            listaUsuario.Add(new Usuario("admin", "admin"));
        }
        public static bool existeUsuario(string usuario, string password)
        {
            //hardodear usuarios
            //siempre true
            //abro archivo de texto con usuarios creado
            var objUsuario = listaUsuario.Find(usuarioObj => usuarioObj.usuario == usuario && usuarioObj.password == password);
                if (objUsuario == null)
                {
                    return false;

                }else{
                    return true;
                }

                //Lamado API
            }
            
        }    
    }

