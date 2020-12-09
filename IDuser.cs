using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas
{
    
    public class IDuser
    {
        public static  string id;
        public string res;
        Conexion con = new Conexion();
        SqlDataReader read;
        SqlCommand cmd = new SqlCommand();




        public void IDus(string user, string pass) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "obteneridempleado";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            read = cmd.ExecuteReader();
            if (read.Read()) {
                id = read["id_empleado"].ToString();

            }
            res = id;
            
            cmd.Parameters.Clear();
            con.CerrarConexion();
            

        }
      
    }
}

