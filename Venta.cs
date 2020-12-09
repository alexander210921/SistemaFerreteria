using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_de_ventas
{
    public class Venta
    {
        private Conexion con = new Conexion();
        SqlDataReader read;
        SqlCommand cmd = new SqlCommand();

        public void ingresarventa(int idcliente, int idproducto,int idempleado,DateTime fecha,string observaciones) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "agregarveventa";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcliente",idcliente);
            cmd.Parameters.AddWithValue("@idproducto",idproducto);
            cmd.Parameters.AddWithValue("@idempleado",idempleado);
            cmd.Parameters.AddWithValue("@fecha",fecha);
            cmd.Parameters.AddWithValue("@observaciones",observaciones);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
            


        
        
        }
    }
}
