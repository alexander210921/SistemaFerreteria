using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_de_ventas
{
    class Ventas
    {
        Conexion con = new Conexion();
        SqlDataReader read;
        SqlCommand cmd = new SqlCommand();

        public void NuevaVenta(string observacion) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "Nueva_venta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@observacon",observacion);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        
        }
        

    }
}
