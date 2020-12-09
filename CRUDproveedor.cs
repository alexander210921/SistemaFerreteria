using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_de_ventas
{
    class CRUDproveedor
    {
        public Conexion con = new Conexion();
        SqlDataReader read;
        SqlCommand cmd = new SqlCommand();
        DataTable table = new DataTable();

        //Mostrar proveedor
        public DataTable Mostrar() {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "mostrarproveedor";
            cmd.CommandType = CommandType.StoredProcedure;
            read = cmd.ExecuteReader();
            table.Load(read);
            con.CerrarConexion();
            return table;
        }
        //ingresar proveedor

        public void Ingresar(string nombre , int telefono ,string email, string pais, string depart,string ubicacion) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "insertarproveedor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre",nombre);
            cmd.Parameters.AddWithValue("@telefono",telefono);
            cmd.Parameters.AddWithValue("@mail",email);
            cmd.Parameters.AddWithValue("@pais",pais);
            cmd.Parameters.AddWithValue("@departamento",depart);
            cmd.Parameters.AddWithValue("@ubicacion", ubicacion);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }
        // buscar
        public DataTable Buscar(String textp) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "buscarproveedor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre",textp);
            read = cmd.ExecuteReader();
            table.Load(read);
            cmd.Parameters.Clear();
            con.CerrarConexion();
            return table;
        }
        // eliminar procveedor
        public void Eliminar(int id ) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "eliminarproveedor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }

        public void Editar(int id, string nombre, int telefono, string email, string pais, string depart, string ubicacion) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "editarproveedor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@mail", email);
            cmd.Parameters.AddWithValue("@pais", pais);
            cmd.Parameters.AddWithValue("@departamento", depart);
            cmd.Parameters.AddWithValue("@ubicacion", ubicacion);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();

        }



    }
}


