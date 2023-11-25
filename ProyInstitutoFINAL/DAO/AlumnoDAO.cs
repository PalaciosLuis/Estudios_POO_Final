using ProyInstitutoFINAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace ProyInstitutoFINAL.DAO
{
    public class AlumnoDAO
    {
        public List<Alumno> BuscarAlumnoPorId(string id)
        {


            var Lista = new List<Alumno>();

            SqlDataReader dr = DBHelper.RetornaReader("BuscarAlumnoPorId",id);

            Alumno obj;

            while (dr.Read())
            {

                obj = new Alumno()
                {
                    codalu = dr.GetString(0),
                    nomalu = dr.GetString(1),
                    telefono = dr.GetString(2),
                    codcar = dr.GetInt32(3),
                    fecha_ins = dr.GetDateTime(4)

                };
                Lista.Add(obj);
            }

            dr.Close();

            return Lista;
        }

        public string ActualizarAlumno(Alumno obj)
        {
            try
            {
                 DBHelper.EjecutarSP("ActualizarAlumno", obj.codalu, obj.nomalu, obj.telefono
                    , obj.codcar, obj.fecha_ins);

                return "el alumno: " + obj.nomalu
                   + "fue actualizado " + "Correctamente";

            }
            catch (Exception ex)
            {


                return "Error" + ex.Message;
            }

        }


        public string AgregarAlumno(Alumno obj)
        {

            try
            {
                DBHelper.EjecutarSP("AgregarAlumno", obj.codalu, obj.nomalu, obj.telefono
                   , obj.codcar, obj.fecha_ins);

                return "el alumno: " + obj.nomalu
                   + "fue registrado " + "Correctamente";

            }
            catch (Exception ex)
            {


                return "Error" + ex.Message;
            }


        }

    }
}