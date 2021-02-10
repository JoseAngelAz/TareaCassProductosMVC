using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Prome.Models
{
    public class GuardarRegistros
    {
        public void Guardar(RegistroAlumnos model)
        {
            
            StreamWriter stream = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/archivo.txt", true);
            stream.WriteLine(
                "<tr>" +
                     "<td>"+model.id+"</td>"+
            
              
                     "<td>" + model.nombre + "</td>" +
             
                     "<td>" + model.descripcion + "</td>" +
                
                     "<td>" + model.precio + "</td>" +
                
               
                    

                      "</tr>" );
            stream.Close();
        }

        public string LeerDatos()
        {
            StreamReader stream = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/archivo.txt", true);
            string contenido = stream.ReadToEnd();
            stream.Close();
            return contenido;
        }
    }
}