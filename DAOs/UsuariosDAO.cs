using Editor.Modelo;
using Newtonsoft.Json;
using RestSharp;
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
      
          var client = new RestClient("https://localhost:44329/");
         
            var request = new RestRequest("/" + usuario + "/" + password + "/MasSeguroImposible");
            request.RequestFormat = DataFormat.Json;
            var response = client.Get(request).Content;
           var estado= JsonConvert.DeserializeObject<dynamic>(response);
            bool mybool = System.Convert.ToBoolean(estado);
            return mybool;
            
             
            }
      
      
        }    
    }

