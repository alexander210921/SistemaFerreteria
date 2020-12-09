using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Sistema_de_ventas
{
    class CRUDcategoria
    {
        Conexion con = new Conexion();
        SqlDataReader read;
        SqlCommand cmd = new SqlCommand();
        DataTable table = new DataTable();

        public DataTable mostrar() {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "VerCategorias";
            cmd.CommandType = CommandType.StoredProcedure;
            read = cmd.ExecuteReader();
            table.Load(read);
            con.CerrarConexion();
            return table;
        
        }
        public void Insertar(string nombre) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "ingresoCategoria";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre",nombre);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }

        public void Actualizar( int id ,string texto  ) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "actualizarcategiria";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcategoria",id);
            cmd.Parameters.AddWithValue("@nombre", texto);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }
        public void eliminar(int id) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "eliminarcategoria";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }
        public DataTable buscar(string texto) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "buscarcategoria";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@texto",texto);
            read = cmd.ExecuteReader();
            table.Load(read);
            con.CerrarConexion();
            return table;
        
        }
    }
}
