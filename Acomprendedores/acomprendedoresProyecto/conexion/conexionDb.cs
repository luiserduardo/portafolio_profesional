using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acomprendedoresProyecto.conexion
{
    public class ConexionDb
    {

        private static string connectionString =
            "Server=localhost\\MSSQLSERVER01; Database=AcomprendedoresDB; Trusted_Connection= True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            return conexion;


        }


    }
}
