using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Sistema_de_ventas
{
    class ProcedimientosDeVerificacion
    {
        Conexion con = new Conexion();
        SqlDataReader read;
        SqlCommand cmd = new SqlCommand();
        DataTable table = new DataTable();
        public  string preci;

        public DataTable formapago(int id ) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "nombreformadepago";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idformapago",id);
            read = cmd.ExecuteReader();
            table.Load(read);
            cmd.Parameters.Clear();
            con.CerrarConexion();
            return table;
        }
        public DataTable nombrecliente(int id) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "nombrecliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_cliente",id);
          
            read = cmd.ExecuteReader();
            table.Load(read);
            cmd.Parameters.Clear();
            con.CerrarConexion();
            return table;



        }
        public DataTable nombreproducto(int id)
        {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "productoinfo2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idproducto", id);
            read = cmd.ExecuteReader();         
            table.Load(read);           
            cmd.Parameters.Clear();
            con.CerrarConexion();
            return table;

        }
        public void preciounitario(int id) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "preciounitario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            read = cmd.ExecuteReader();
            if (read.Read()) {

                preci = read["precio_venta"].ToString();
            }
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }



    }
}

