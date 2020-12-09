using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_de_ventas
{
    class Conexion
    {

        private SqlConnection Connec = new SqlConnection("Server=(local);DataBase= dbventa;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Connec.State == ConnectionState.Closed)
                Connec.Open();
            return Connec;
        }
        public SqlConnection CerrarConexion()
        {
            if (Connec.State == ConnectionState.Open)
                Connec.Close();
            return Connec;
        }
    }
}
