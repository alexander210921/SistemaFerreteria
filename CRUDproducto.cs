using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas
{
    class CRUDproducto        
    {
        private Conexion con = new Conexion();
        SqlDataReader read;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();
        //mostrar producto
        public DataTable Mostrar() {

            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "mostrarproductos";
            cmd.CommandType = CommandType.StoredProcedure;
            read = cmd.ExecuteReader();
            table.Load(read);
            con.CerrarConexion();
            return table;
        }

        //insertar producto 
        public void Insertar(int categoria, int proveedor,string nombre, string descripcion,decimal preciocompra, decimal precioventa,decimal descuento,int existencia, int empleadoqueingreso,DateTime fechadeingreso) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "insertarproducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_categoria",categoria);
            cmd.Parameters.AddWithValue("@id_proveedor",proveedor);
            cmd.Parameters.AddWithValue("@nombre",nombre);
            cmd.Parameters.AddWithValue("@descripcion",descripcion);
            cmd.Parameters.AddWithValue("@preciocompra",preciocompra);
            cmd.Parameters.AddWithValue("@precioventa",precioventa);
            cmd.Parameters.AddWithValue("@descuento",descuento);
            cmd.Parameters.AddWithValue("@cantidad",existencia);
            cmd.Parameters.AddWithValue("@ingresadopor",empleadoqueingreso);
            cmd.Parameters.AddWithValue("@fechaingreso",fechadeingreso);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }

        // buscar productos
        public DataTable buscarproducto(string text)
        {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "buscarproducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombredelproducto", text);
            read = cmd.ExecuteReader();
            table.Load(read);
            cmd.Parameters.Clear();
            con.CerrarConexion();
            return table;
        }

        // eliminar producto 

        public void Eliminar(int id_produc) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "eliminarproducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idproducto",id_produc);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();

        }

        public void Modificar(int idproducto,int categoria, int proveedor, string nombre, string descripcion, decimal preciocompra, decimal precioventa, decimal descuento, int existencia, int empleadoqueingreso, DateTime fechadeingreso) {

            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "actualizarproducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idproducto", idproducto);
            cmd.Parameters.AddWithValue("@id_categoria", categoria);
            cmd.Parameters.AddWithValue("@id_proveedor", proveedor);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@preciocompra", preciocompra);
            cmd.Parameters.AddWithValue("@precioventa", precioventa);
            cmd.Parameters.AddWithValue("@descuento", descuento);
            cmd.Parameters.AddWithValue("@cantidad", existencia);
            cmd.Parameters.AddWithValue("@ingresadopor", empleadoqueingreso);
            cmd.Parameters.AddWithValue("@fechaingreso", fechadeingreso);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }


    }
}
