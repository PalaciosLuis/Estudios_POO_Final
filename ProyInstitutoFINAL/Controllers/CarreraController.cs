using ProyInstitutoFINAL.DAO;
using ProyInstitutoFINAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace ProyInstitutoFINAL.Controllers
{
    public class CarreraController : Controller
    {
        CarreraDAO dao_carrera=new CarreraDAO();
        
        // GET: Carrera
        public ActionResult ListarCarreras()
        {

            var listado = dao_carrera.ListarCarreras();

            return View(listado);
        }

        // GET: Carrera/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Carrera/Create
        public ActionResult AgregarCarrera()
        {

            Carrera carrera= new Carrera();
            carrera.nomcar = "Nombra la carrera";
            
            return View(carrera);
        }

        // POST: Carrera/Create
        [HttpPost]
        public ActionResult AgregarCarrera(Carrera obj)
        {
            try
            {
                if (ModelState.IsValid == true)
                    ViewBag.Mensaje = dao_carrera.AgregarCarrera(obj);
                // TODO: Add insert logic here


            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;


            }
            return View(obj);
        }

        // GET: Carrera/Edit/5
        public ActionResult ActualizarCarrera(int id)
        {
            Carrera carrera = new Carrera();
            carrera.codcar= id;
            

            return View(carrera);
        }

        // POST: Carrera/Edit/5
        [HttpPost]
        public ActionResult ActualizarCarrera(int id,Carrera obj)
        {
            try
            {
                if (ModelState.IsValid == true)
                    ViewBag.Mensaje = dao_carrera.ActualizarCarrera(obj);
                // TODO: Add update logic here


            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;

            }

            return View(obj);
        }

        // GET: Carrera/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Carrera/Delete/5
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
