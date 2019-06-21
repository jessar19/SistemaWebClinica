using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
   public  class EmpleadoDAO
    {
            #region "PATRON SINGLETON"

            //atributo de conexion
            private static EmpleadoDAO daoEmpleado = null;

            //ocultar constructor
            private EmpleadoDAO() { }

            //retornar una instancia de esta conexion 
            public static EmpleadoDAO getInstance()
            {
                //si no se ah echo una instancia de este objeto.
                if (daoEmpleado == null)
                {
                    daoEmpleado = new EmpleadoDAO();

                }
                return daoEmpleado;
            }

            #endregion

            //metodo para acceso al sistema

            public Empleado AccesoSistema(String user, String pass)
            {
                SqlConnection conexion = null;
                SqlCommand cmd = null;
                Empleado objEmpleado = null;
                SqlDataReader dr = null;

                try
                {
                    //crear conexion
                    conexion = Conexion.getInstance().ConexionBD();

                //crear comando (enviar comando)
                cmd = new SqlCommand("spAccesoSistema", conexion)
                {

                    //indicar el tipo de comando 
                    CommandType = CommandType.StoredProcedure
                };

                //enviar paramentros a store procedure
                cmd.Parameters.AddWithValue("@prmUser", user);
                    cmd.Parameters.AddWithValue("@prmPass", pass);

                    conexion.Open();

                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                    objEmpleado = new Empleado
                    {
                        //convertir string  a entero.

                        ID = Convert.ToInt32(dr["idEmpleado"].ToString()),

                        Usuario = dr["usuario"].ToString(),

                        Clave = dr["clave"].ToString()
                    };
                }


                }
                catch (Exception ex)
                {
                    objEmpleado = null;
                    throw ex;


                }
                finally
                {
                    conexion.Close();

                }

                return objEmpleado;


            }


        }
    }
