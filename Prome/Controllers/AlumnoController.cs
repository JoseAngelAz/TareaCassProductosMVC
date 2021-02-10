using Prome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rotativa;
using System.Web.Mvc;

namespace Prome.Controllers
{
    public class AlumnoController : Controller
    {
        //instanciamos la clase donde enviaremos datos 
        RegistroAlumnos modelo = new RegistroAlumnos();

        //instanciamos la clase donde guardaremos los datos 
        GuardarRegistros registros = new GuardarRegistros();


        public ActionResult Index()
        {
            return View();
        }

        //Agregando alumno para enviar al modelo
        public ActionResult AgregarAlumno()
        {

            return View(modelo);
        }

        [HttpPost]
        //modelo a traves del formulario 
        public ActionResult AgregarAlumno(RegistroAlumnos alumnos)
        {
            if (ModelState.IsValid)
            {
                registros.Guardar(alumnos);
                return View("Correcto");
            }
            else
            {
                return View(alumnos);
            }
          
        }

        public ActionResult MostrarDatos()
        {
            string contenido = registros.LeerDatos();
            ViewData["datos"] = contenido;

            return View();
        }
         public ActionResult ImprimirPDF()
        {
            string contenido = registros.LeerDatos();
            ViewData["datos"] = contenido;
            return new ViewAsPdf("IndexPDF")
            {
                PageSize = Rotativa.Options.Size.A4,
                PageMargins = new Rotativa.Options.Margins(20,10,20,10),
                FileName = "Datos.pdf"
            };
        }
      


    }

}