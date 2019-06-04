using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        #region "PATRON SINGLETON"

        //atributo de conexion
        public static Conexion conexion = null;

        //ocultar constructor
        private Conexion() { }

        //retornar una instancia de esta conexion 
        public static Conexion getInstance()
        {
            if (conexion == null)
            {
                conexion = new Conexion();

            }
            return conexion;
        }

        #endregion

        public SqlConnection ConexionBD()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=(local); Initial Catalog=DBClinica_test;"
             + "Integrated Security=SSPI;";
            return conexion;
        }
    }
}
