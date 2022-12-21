namespace CapaAccesoDatos
{
    using System.Data.SqlClient; //Para conectarse a la baase de datos en SQL
    public abstract class ConexionASQL 
    {
        private readonly string connectionString;

        public ConexionASQL()
        {
            connectionString = "Data Source=(local)\\SQLEXPRESS; DataBase=ArquitecturaProyecto; integrated security=true";
            //connectionString = "Server = localhost\\SQLEXPRESS; Database = proyectoArquitectura; Trusted_Connection = True";
        }

        //Para proteger la conexion
        protected SqlConnection GetConnection() 
                                   //El nombre por el cual se enlaza a la capa de soporte ->UsuarioCache.
        {
            return new SqlConnection(connectionString); //Regresa la conexion.
        }    
    }
}
