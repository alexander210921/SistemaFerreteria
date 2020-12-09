using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_de_ventas
{
  public   class Numventaactual
    {
        
        Conexion con = new Conexion();
        SqlDataReader read;
        SqlCommand cmd = new SqlCommand();
        public static  string numero;

        public void numventa() {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "Nventas";
            cmd.CommandType = CommandType.StoredProcedure;
            read = cmd.ExecuteReader();
            if (read.Read()) {
                numero = read["id_numVenta"].ToString();
            
            }
            cmd.Parameters.Clear();
            con.CerrarConexion();
            
            
        
        }
        
    }
}
