namespace CapaAccesoDatos
{
    using System.Data.SqlClient;
    using System.Data;
    using CapaSoporte.Cache; //Se tiene que tener referencia a la capa, se distinguen mayusculas y minusculas.

    public class UsuarioDAO:ConexionASQL
    {                       //Parametros
        public bool Login(string user, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open(); //ERRO AL MOMENTO DE INGRESAR MIS DATOS.
                using (var command = new SqlCommand()) //Para ejecutar un query
                {
                    command.Connection = connection;
                    //Se verigfica si hay un usuario con un nombre y una contraseña.
                    command.CommandText = "Select * FROM Usuarios WHERE Usuario=@user AND Contraseña=@password AND Activo='true'";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@password", password);
                    command.CommandType = CommandType.Text; //Cadena de conexion.
                    SqlDataReader reader = command.ExecuteReader(); //Se ejecuta la cadena de conexion.
                    if(reader.HasRows) //Se encontro el usuario
                    {   //Se almacena la informacion.
                        while(reader.Read())
                        {
                            UsuarioCache.IDUsuario = reader.GetInt32(0); //Es la posicion 0.
                            UsuarioCache.IDTipoUsuario = reader.GetInt32(1);
                            UsuarioCache.Nombre = reader.GetString(2);
                            UsuarioCache.ApellidoPaterno = reader.GetString(3);
                            UsuarioCache.ApellidoMaterno = reader.GetString(4);
                            UsuarioCache.Usuario = reader.GetString(5);
                            UsuarioCache.Contraseña = reader.GetString(6);
                            UsuarioCache.Activo = reader.GetBoolean(7);
                        }
                        return true;
                    }
                    else
                    {
                        return false; //No se encontro un usuario.
                    }
                }
            }
        }

        public void InsertarUsuario(int IDUsuario, int IDTipoUsuario, string Nombre, string ApellidoPaterno, string ApellidoMaterno, string Usuario, string Contraseña)
        {
            //El usuario estara por defecto activo
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand()) //Se genera una variable comando
                {
                    //Se define la coneneccion
                    {
                        command.Connection = connection;
                        //Para instertar valores: Si es int: "+NombreVariable+" ; si es char: '"+NombreVariable+"? ; si es booleana: 'true' o 1 
                        command.CommandText = "Insert into Usuarios Values(" +IDUsuario+ ", " + IDTipoUsuario + ", '" + Nombre + "', '" + ApellidoPaterno + "', '" + ApellidoMaterno + "', '" + Usuario + "', '" + Contraseña + "', 'true')";
                        command.ExecuteNonQuery(); //Se ejecuta la setencia sql.
                    }
                }
            }
        }

        public void BorrarUsuario(int IDUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand()) //Se genera una variable comando
                {
                    //Se define la coneneccion
                    {
                        string Activo = "false"; //Se hace la baja logica.
                        command.Connection = connection;
                        command.CommandText = "Update Usuarios SET Activo = '" + Activo + "' WHERE IDUsuario = " + IDUsuario; //Actualiza la tabla
                        command.ExecuteNonQuery(); //Se ejecuta la setencia sql.
                    }
                }
            }
        }

        public void EditarUsuario(int IDUsuario, int IDTipoUsuario, string Nombre, string ApellidoPaterno, string ApellidoMaterno, string Usuario, string Contraseña, bool Activo)
        {
            //El usuario estara por defecto activo
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand()) //Se genera una variable comando
                {
                    //Se define la coneneccion
                    {
                        command.Connection = connection;
                        command.CommandText = "Update Usuarios SET IDUsuario= "+ IDUsuario +", IDTipoUsuario= "+IDTipoUsuario+", Nombre = '"+Nombre+"', ApellidoPaterno= '"+ApellidoPaterno+"', ApellidoMaterno= '"+ApellidoMaterno+"', Usuario= '"+Usuario+"', Contraseña='"+Contraseña+"', Activo='"+Activo+"' WHERE IDUsuario = " + IDUsuario +"";
                        command.ExecuteNonQuery(); //Se ejecuta la setencia sql.
                    }
                }
            }
        }

        public bool VerificarUsuario(string Nombre, string ApellidoPaterno, string ApellidoMaterno, string Usuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open(); 
                using (var command = new SqlCommand()) //Para ejecutar un query
                {
                    command.Connection = connection;
                    //Se verigfica todos los usuarios dondde el nombre sea igual 
                    command.CommandText = "Select * FROM Usuarios WHERE Nombre=@Nombre AND ApellidoPaterno=@ApellidoPaterno AND ApellidoMaterno=@ApellidoMaterno AND Usuario=@Usuario";
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@ApellidoPaterno", ApellidoPaterno);
                    command.Parameters.AddWithValue("@ApellidoMaterno", ApellidoMaterno);
                    command.Parameters.AddWithValue("@Usuario", Usuario);
                    command.CommandType = CommandType.Text; //Cadena de conexion.
                    SqlDataReader reader = command.ExecuteReader(); //Se ejecuta la cadena de conexion.
                    if (reader.HasRows) //Se encontro el usuario
                    {   
                        return true;
                    }
                    else
                    {
                        return false; //No se encontro un usuario.
                    }
                }
            }
        }
    }
}
