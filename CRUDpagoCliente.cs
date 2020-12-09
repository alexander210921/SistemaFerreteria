using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Sistema_de_ventas
{
    class CRUDpagoCliente
    {
        Conexion con = new Conexion();
        SqlDataReader read;
        SqlCommand cmd = new SqlCommand();
        DataTable table = new DataTable();

        public DataTable VerPagos() {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "VerPagos";
            cmd.CommandType = CommandType.StoredProcedure;
            read = cmd.ExecuteReader();
            table.Load(read);
            con.CerrarConexion();
            return table;
        }
        public void agregar(int idpago , int idempleado,decimal monto , string motivo,DateTime fecha) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "pagoempleados";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idtipopago",idpago);
            cmd.Parameters.AddWithValue("@idempleado",idempleado);
            cmd.Parameters.AddWithValue("@monto", monto);
            cmd.Parameters.AddWithValue("@descripcion", motivo);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }
        public DataTable Verificar(int idempleado , int idformapago) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "verificarpago";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idempleado",idempleado);
            cmd.Parameters.AddWithValue("@idformapago",idformapago);
            read = cmd.ExecuteReader();
            table.Load(read);
            cmd.Parameters.Clear();
            con.CerrarConexion();
            return table;
        }
        public void Editar(int numeropago, int idpago, int idempleado, decimal monto, string motivo, DateTime fecha) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "editarPagos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numpago",numeropago);
            cmd.Parameters.AddWithValue("@idtipopago", idpago);
            cmd.Parameters.AddWithValue("@idempleado", idempleado);
            cmd.Parameters.AddWithValue("@monto", monto);
            cmd.Parameters.AddWithValue("@descripcion", motivo);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }
        public void eliminar(int idumpago) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "eliminarpago";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idnumpago", idumpago);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }
    }
}
