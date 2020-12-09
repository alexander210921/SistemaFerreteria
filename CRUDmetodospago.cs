using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Sistema_de_ventas
{
    class CRUDmetodospago
    {
        Conexion con = new Conexion();
        SqlDataReader read;
        SqlCommand cmd = new SqlCommand();
        DataTable table = new DataTable();
        public DataTable Mostrar() {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "tipospagomostrar";
            cmd.CommandType = CommandType.StoredProcedure;
            read = cmd.ExecuteReader();
            table.Load(read);
            return table;
        }
        public void Agregar(string descripciom) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "agregarpago";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descripcion",descripciom);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        
        }
        public void actualizar(int id, string descripciom) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "actualizarPago";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idpago", id);
            cmd.Parameters.AddWithValue("@descripcion", descripciom);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }
        public void eliminar(int id)
        {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "eliminarformadepago";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idtipopago",id);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }

        public DataTable buscar(string texto) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "buscar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@texto", texto);
            read = cmd.ExecuteReader();
            table.Load(read);
            cmd.Parameters.Clear();
            con.CerrarConexion();
            return table;
        }
    }
}
