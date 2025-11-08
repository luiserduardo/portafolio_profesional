using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acomprendedoresProyecto.conexion;

namespace acomprendedoresProyecto.repositorios
{
    public class LoginRepositorio
    {
        
        //Verificar Credenciales y devolver usuario
        public string login(string codigoUsuario, string clave)
        {
            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            {
                string query = "SELECT TipoUsuario FROM Usuario WHERE CodigoUsuario = @Codigo AND Clave = @Clave";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    
                    cmd.Parameters.AddWithValue("@Codigo", codigoUsuario.Trim());
                    cmd.Parameters.AddWithValue("@Clave", clave.Trim());

                    object resultado = cmd.ExecuteScalar(); 

                    if (resultado == null || resultado == DBNull.Value)
                        return null;

                    return resultado.ToString();
                }
            }
        }

    }
}
