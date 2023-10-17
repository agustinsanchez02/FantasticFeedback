using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticFeedback__FF_
{
    public class Basededatos: ConexionSQL
    {
        public DataTable ListarUsuario()
        {
            DataTable dataTable = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select IDusuario, Usuario, Nombre, Apellido, Email from Clientes";
                    command.CommandType = CommandType.Text;
                    SqlDataReader resultado = command.ExecuteReader();
                    if (resultado.HasRows)
                    {
                        dataTable.Load(resultado);
                    }
                    return dataTable;
                }
            }
        }
    }
}
