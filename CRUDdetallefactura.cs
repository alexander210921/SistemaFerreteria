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
    class CRUDdetallefactura
    {
        Conexion con = new Conexion();
        SqlDataReader read;
        SqlCommand cmd = new SqlCommand();
        public string total;

        public void Insertar(int idventa, int idcliente , int idproducto,int idempleado,int idtipopago,DateTime fecha, int cantidad, decimal precio, int nit,int total, decimal montoapagar, decimal vuelto) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "agregardetallefactura";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idnumventa",idventa);
            cmd.Parameters.AddWithValue("@idcliente",idcliente);
            cmd.Parameters.AddWithValue("@idproducto",idproducto);
            cmd.Parameters.AddWithValue("@idempleado",idempleado);
            cmd.Parameters.AddWithValue("@idtipopago", idtipopago);
            cmd.Parameters.AddWithValue("@fecha",fecha);
            cmd.Parameters.AddWithValue("@cantidad",cantidad);
            cmd.Parameters.AddWithValue("@preciouni",precio);
            cmd.Parameters.AddWithValue("@NIT",nit);
            cmd.Parameters.AddWithValue("@total",total);
            cmd.Parameters.AddWithValue("@montoapagar",montoapagar);
            cmd.Parameters.AddWithValue("@vuelto",vuelto);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();

        
        
        }

        public void TOTAL(int id) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "totalgastos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idventa",id);
            read = cmd.ExecuteReader();
            if (read.Read()) {

                total = read["TOTAL"].ToString();

            }

            cmd.Parameters.Clear();
            con.CerrarConexion();

        
        }

        public void Updateexistencias(int idproducto , int cantidadAdescontar) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "descontarstock";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idproducto",idproducto);
            cmd.Parameters.AddWithValue("@cantidadadescontar",cantidadAdescontar);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }
        public void PagoVuelto(int idventa, decimal pago, decimal vuelto, int total) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "VueltpyPago1";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idventa",idventa);
            cmd.Parameters.AddWithValue("@montoApagar",pago);
            cmd.Parameters.AddWithValue("@vuelto",vuelto);
            cmd.Parameters.AddWithValue("@total",total);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        
        }
        public void Montpagar(decimal monto,int id) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "montoapagar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@monto", monto);
            cmd.Parameters.AddWithValue("@idventa",id);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
                
        }
        public void vuelto(decimal vuelto , int venta) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "Vuelto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@vuelto",vuelto);
            cmd.Parameters.AddWithValue("@idventa",venta);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }

    }
}
