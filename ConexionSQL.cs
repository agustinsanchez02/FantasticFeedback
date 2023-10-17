using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticFeedback__FF_
{
    public abstract class ConexionSQL
    {
        private readonly string ConnectionString;
        public ConexionSQL()
        {
            ConnectionString = "Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = FantasticFeedback; Integrated Security = True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);


        }
    }
}

