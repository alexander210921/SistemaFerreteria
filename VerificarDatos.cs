using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_de_ventas
{
    
    class VerificarDatos
    {
        
        Conexion con = new Conexion();
        SqlDataReader red;
        SqlCommand cmd = new SqlCommand();
        DataTable table = new DataTable();
        
        public bool rpt;
        
        
        public DataTable Mostrar(int id_cliente, int id_producto) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "VerificarDatos2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
            cmd.Parameters.AddWithValue("@idproducto", id_producto);
            red = cmd.ExecuteReader();
            table.Load(red);
            if (table.Rows.Count > 0)
            {
                rpt = true;
            }
            else
            {
                rpt = false;
            }

            cmd.Parameters.Clear();
            con.CerrarConexion();
            return table;
        
        
        }

    }
}
