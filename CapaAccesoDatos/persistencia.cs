namespace CapaAccesoDatos
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class persistencia : ConexionASQL
    {
        public int SiguienteID(string TableName, string IDField)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    int val; //Guarda la parte entera del ID.
                    command.Connection = connection;
                    command.CommandText = "Select MAX(" + IDField + ") From " + TableName; //Busca en la base de dtos y encuentra el mayor.
                    object maxValue = command.ExecuteScalar();
                    connection.Close();
                    if(maxValue == DBNull.Value)
                    {
                        return 1;
                    }
                    else 
                    {
                        val = int.Parse((maxValue).ToString()); //Convierte la cadena de texto en un numero.
                        return val + 1;
                    }
                }
            }
        }
    }
}
