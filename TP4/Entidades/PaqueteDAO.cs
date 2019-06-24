using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PaqueteDAO
    {

        private static SqlCommand comando;
        private static SqlConnection conexion;

        static PaqueteDAO()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=correo-sp-2017; Integrated Security=True;";
            conexion = new SqlConnection(connectionString);
        }

        public static bool Insertar(Paquete p)
        {
            try
            {
                conexion.Open();
                string alumno = "Kenji Ushiro";
                string insertCommand = string.Format("INSERT INTO Paquetes (direccionEntrega,trackingID,alumno) " +
                                            "VALUES('{0}','{1}','{2}')",p.DireccionEntrega, p.TrackingID, alumno);
                comando = new SqlCommand(insertCommand, conexion);
                comando.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }


        }

    }
}
