using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Permissions;

namespace Sistema_de_ventas
{
    class CRUDempleado
    {
        private Conexion con = new Conexion();
        SqlDataReader read;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();
        // mostrar empleado
        public DataTable Mostrar() {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "mostrarempleados";
            cmd.CommandType = CommandType.StoredProcedure;
            read = cmd.ExecuteReader();
            table.Load(read);          
            con.CerrarConexion();
            return table;
        }
        // insertar empleado
        public void Insertar(string nombre , string apellido ,string sexo ,DateTime fecha_nac,int telefono, long DPI, double salario,string email , string pais, string departamento,string ubicacion,string usuario,string password,string acceso, byte[] foto) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "ingresarempleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido",apellido);
            cmd.Parameters.AddWithValue("@sexo",sexo);
            cmd.Parameters.AddWithValue("@fechanac",fecha_nac);
            cmd.Parameters.AddWithValue("@telefono",telefono);
            cmd.Parameters.AddWithValue("@DPI",DPI);
            cmd.Parameters.AddWithValue("@Salario",salario);
            cmd.Parameters.AddWithValue("@email",email);
            cmd.Parameters.AddWithValue("@pais",pais);
            cmd.Parameters.AddWithValue("@departamento",departamento);
            cmd.Parameters.AddWithValue("@ubicacion",ubicacion);
            cmd.Parameters.AddWithValue("@usuario",usuario);
            cmd.Parameters.AddWithValue("@password",password);
            cmd.Parameters.AddWithValue("@acceso",acceso);
            cmd.Parameters.AddWithValue("@imagen", foto);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }
        // eliminar empleado
        public void Eliminar(int id ) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "eliminarempleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);
            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }
        // editar empleado
        public void Editar(int id, string nombre, string apellido, string sexo, DateTime fecha_nac, int telefono, long DPI, double salario, string email, string pais, string departamento, string ubicacion, string usuario, string password, string acceso, byte[] foto) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "actualizarempleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@fechanac", fecha_nac);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@DPI", DPI);
            cmd.Parameters.AddWithValue("@Salario", salario);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pais", pais);
            cmd.Parameters.AddWithValue("@departamento", departamento);
            cmd.Parameters.AddWithValue("@ubicacion", ubicacion);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@acceso", acceso);
            cmd.Parameters.AddWithValue("@imagen", foto);

            read = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            con.CerrarConexion();
        }
        //buscar empleado
        public DataTable Buscar(string text) {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "buscarempleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@text",text);
            read = cmd.ExecuteReader();
            table.Load(read);
            con.CerrarConexion();
            return table;
        }
    }
}
