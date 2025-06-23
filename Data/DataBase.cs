using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyProductoCRUD.Data {
    public class DataBase {
        /// <summary>
        /// Obtiene una conexión a la base de datos SQL Server.
        /// </summary>
        /// <returns>
        /// Objecto SqlConnection configurado.
        /// </returns>
        public static SqlConnection ObtenerConexion() {
            // Instanciar la clase generadora de cadenas de conexión
            SqlConnectionStringBuilder builderCnx = new SqlConnectionStringBuilder();
            // Configurar los parámetros de la cadena de conexión
            builderCnx.DataSource = "localhost";    // Ubicación del servidor SQL Server
            builderCnx.InitialCatalog = "BD_Producto";  // Nombre de la base de datos
            builderCnx.UserID = "sa";   // Usuario de la base de datos
            builderCnx.Password = "sql";    // Contraseña del usuario
            // Crear la cadena de conexión
            SqlConnection conexion = new SqlConnection(builderCnx.ConnectionString);
            // Retornar la conexión
            return conexion;
        }
    }
}