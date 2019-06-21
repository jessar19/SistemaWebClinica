using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class PacienteDAO
    {
        #region "PATRON SINGLETON"
        private static PacienteDAO daoEmpleado = null;
        private PacienteDAO() { }
        public static PacienteDAO getInstance()
        {
            if (daoEmpleado == null)
            {
                daoEmpleado = new PacienteDAO();
            }
            return daoEmpleado;
        }
        #endregion

        public bool RegistrarPaciente(Paciente objPaciente)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spRegistrarPaciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmNombres", objPaciente.Nombres);
                cmd.Parameters.AddWithValue("@prmApPaterno", objPaciente.ApPaterno);
                cmd.Parameters.AddWithValue("@prmApMaterno", objPaciente.ApMaterno);
                cmd.Parameters.AddWithValue("@prmEdad", objPaciente.Edad);
                cmd.Parameters.AddWithValue("@prmSexo", objPaciente.Sexo);
                cmd.Parameters.AddWithValue("@prmNroDoc", objPaciente.NroDocumento);
                cmd.Parameters.AddWithValue("@prmDireccion", objPaciente.Direccion);
                cmd.Parameters.AddWithValue("@prmTelefono", objPaciente.Telefono);
                cmd.Parameters.AddWithValue("@prmEstado", objPaciente.Estado);
                con.Open();

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0) response = true;

            }
            catch (Exception ex)
            {
                response = false;
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return response;
        }
    }
}
