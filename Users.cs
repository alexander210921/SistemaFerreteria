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
   public class Users
    {
        private Conexion con = new Conexion();
        SqlDataReader read;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public string cosn=null;
        public static  string acceso;
        public bool rpt;

        public void verificarusuario(string user ,string pass) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "logi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user",user);
            cmd.Parameters.AddWithValue("@pass",pass);
            read = cmd.ExecuteReader();           
            table.Load(read);           
            if (table.Rows.Count > 0)
            {
                rpt = true;



            }
            else {
                rpt = false;
            }
            
            cmd.Parameters.Clear();
            con.CerrarConexion();
            

        }



        public void verificarROL(string user, string pass)
        {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "logi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                acceso = read["acceso"].ToString();
                
            }           
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }

    }
}
