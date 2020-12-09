using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Sistema_de_ventas
{
    class CRUDcliente
    {
        private Conexion con = new Conexion();
        SqlDataReader read;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();
        //mostrar producto
        public DataTable Mostrar() {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "mostrarclientes";
            cmd.CommandType = CommandType.StoredProcedure;
            read = cmd.ExecuteReader();
            table.Load(read);
            con.CerrarConexion();
            return table;
        }

        //insertar un cliente
        public void Ingresar(string nombre, string apellido, int telefono, string email, string pais, string depto, string ubic) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "agregarcliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pais", pais);
            cmd.Parameters.AddWithValue("@departamento", depto);
            cmd.Parameters.AddWithValue("@ubicacion",ubic);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }
        //buscar cliente
        public DataTable Buscar(string texto) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "buscarclientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", texto);
            read = cmd.ExecuteReader();
            table.Load(read);
            cmd.Parameters.Clear();
            con.CerrarConexion();
            return table;
        }
        //eliminar cliente
        public void Eliminar(int id) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "eliminarcliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }

        //editar cliente
        public void Editar(int id, string nombre, string apellido, int telefono, string email, string pais, string depto, string ubic) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "editarcliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pais", pais);
            cmd.Parameters.AddWithValue("@departamento", depto);
            cmd.Parameters.AddWithValue("@ubicacion", ubic);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }
    }
}

