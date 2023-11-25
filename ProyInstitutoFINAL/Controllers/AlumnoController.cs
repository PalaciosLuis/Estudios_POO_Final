using ProyInstitutoFINAL.DAO;
using ProyInstitutoFINAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyInstitutoFINAL.Controllers
{
    public class AlumnoController : Controller
    {


        AlumnoDAO dao_alumno=new AlumnoDAO();
        
        // GET: Alumno
        public ActionResult BuscarAlumnoPorId(string codalu="")
        {
            var listado = dao_alumno.BuscarAlumnoPorId(codalu);
            return View(listado);
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alumno/Create
        public ActionResult AgregarAlumno()
        {

            Alumno alumno = new Alumno();
            alumno.codalu = "A00000?";
            alumno.fecha_ins = new DateTime(2000, 05, 10);
            return View(alumno);
        }

        // POST: Alumno/Create
        [HttpPost]
        public ActionResult AgregarAlumno(Alumno obj)
        {
            try
            {
                if (ModelState.IsValid == true)
                    ViewBag.Mensaje = dao_alumno.AgregarAlumno(obj);
                // TODO: Add insert logic here

              
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;


            }
            return View(obj);
        }

        // GET: Alumno/Edit/5
        public ActionResult ActualizarAlumno(string codalu)
        {
            Alumno alumno= new Alumno();
            alumno.codalu = codalu;
            alumno.fecha_ins = new DateTime(2000, 05, 10);

            return View(alumno);
        }

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult ActualizarAlumno(string codalu,Alumno obj)
        {
            try
            {
                if (ModelState.IsValid == true)
                    ViewBag.Mensaje = dao_alumno.ActualizarAlumno(obj);
                // TODO: Add update logic here

               
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                
            }

            return View(obj);
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Alumno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
