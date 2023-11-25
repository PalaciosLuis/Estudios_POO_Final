using ProyInstitutoFINAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyInstitutoFINAL.DAO
{
    public class CarreraDAO
    {
        public List<Carrera> ListarCarreras()
        {
            var Lista = new List<Carrera>();

            SqlDataReader dr = DBHelper.RetornaReader("ListarCarreras");

            Carrera obj;

            while (dr.Read())
            {

                obj = new Carrera()
                {
                    codcar = dr.GetInt32(0),
                    nomcar = dr.GetString(1)
                   
                };
                Lista.Add(obj);

            }

            dr.Close();

            return Lista;


        }

        public string ActualizarCarrera(Carrera obj)
        {

            try
            {
                DBHelper.EjecutarSP("ActualizarCarrera", obj.codcar, obj.nomcar);

                return "La carrera: " + obj.nomcar
                   + "fue actualizado " + "Correctamente";

            }
            catch (Exception ex)
            {


                return "Error" + ex.Message;
            }

        }

        public string AgregarCarrera(Carrera obj)
        {

            try
            {
                DBHelper.EjecutarSP("AgregarCarrera", obj.codcar, obj.nomcar);

                return "el alumno: " + obj.nomcar
                   + "fue registrado " + "Correctamente";

            }
            catch (Exception ex)
            {


                return "Error" + ex.Message;
            }


        }
    }
}