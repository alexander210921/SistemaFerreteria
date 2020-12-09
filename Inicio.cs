using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
namespace Sistema_de_ventas
{
    public partial class Inicio : Form
    {

         
        SqlConnection Connec = new SqlConnection("Server=(local);DataBase= dbventa;Integrated Security=true");
        SqlDataReader  read;
        SqlCommand cmd = new SqlCommand();
        public int contador2=1;

        public int contador=1;

        public Inicio()
        {
            InitializeComponent();
            GraficoProductosPreferidos();
            GraficoCliente();
            DatosDeLaEmpresa();
            Ganancias();
            if (Articulos.Existencias==false)
            {
                pictureBox19.Visible = true;
                textBox1.Text = "Quedan Articulos con poca existencia,Verifica el stock";
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        ArrayList nombreproducto = new ArrayList();
        ArrayList CantidadVentas = new ArrayList();
        ArrayList cliente = new ArrayList();
        ArrayList vecesCompra = new ArrayList();
        public void GraficoProductosPreferidos() {
            cmd = new SqlCommand("ProductosPreferidos", Connec);
            cmd.CommandType = CommandType.StoredProcedure;
            Connec.Open();
            read = cmd.ExecuteReader();
            while (read.Read()) {
                nombreproducto.Add(read.GetString(0));
                CantidadVentas.Add(read.GetInt32(1));


            }
            chart1.Series[0].Points.DataBindXY(nombreproducto,CantidadVentas);
            read.Close();
            Connec.Close();
        }
        public void GraficoCliente()
        {
            cmd = new SqlCommand("top5clientesmasrecurrentes", Connec);
            cmd.CommandType = CommandType.StoredProcedure;
            Connec.Open();
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                cliente.Add(read.GetString(0));
                vecesCompra.Add(read.GetInt32(1));


            }
            chart2.Series[0].Points.DataBindXY(cliente, vecesCompra);
            read.Close();
            Connec.Close();
        }

        private void DatosDeLaEmpresa()
        {

            cmd = new SqlCommand("Datosdelsistema",Connec);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter totalenventas = new SqlParameter("@totalventa",0); totalenventas.Direction = ParameterDirection.Output;
            SqlParameter totalproductos = new SqlParameter("@totalproductos",0); totalproductos.Direction = ParameterDirection.Output;
            SqlParameter totalclientes = new SqlParameter("@totalcliente", 0); totalclientes.Direction = ParameterDirection.Output;
            SqlParameter totalproveedores = new SqlParameter("@totalproveedores",0);totalproveedores.Direction = ParameterDirection.Output;
            SqlParameter totalempleados = new SqlParameter("@totalempleados",0);totalempleados.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(totalenventas);
            cmd.Parameters.Add(totalproductos);
            cmd.Parameters.Add(totalclientes);
            cmd.Parameters.Add(totalproveedores);
            cmd.Parameters.Add(totalempleados);
            Connec.Open();
            cmd.ExecuteNonQuery();
            label7.Text = cmd.Parameters["@totalventa"].Value.ToString();
            label9.Text = cmd.Parameters["@totalproductos"].Value.ToString();
            label10.Text = cmd.Parameters["@totalcliente"].Value.ToString();
            label12.Text = cmd.Parameters["@totalproveedores"].Value.ToString();
            label14.Text = cmd.Parameters["@totalempleados"].Value.ToString();
            Connec.Close();
        }
        public void Ganancias() {
            cmd = new SqlCommand("Ganancias", Connec);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter totaleGanancia = new SqlParameter("@totalGanancias", 0); totaleGanancia.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(totaleGanancia);          
            Connec.Open();
            cmd.ExecuteNonQuery();
            label16.Text = cmd.Parameters["@totalGanancias"].Value.ToString();
            
            Connec.Close();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
            proveedor.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Articulos articulo = new Articulos();
            articulo.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Nueva_Venta venta = new Nueva_Venta();
            venta.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox2.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Nueva_Venta venta = new Nueva_Venta();
            venta.Show();
            this.Hide();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
            if (contador % 2 != 0)
            {
                panel10.Visible = true;
            }
            else {
                panel10.Visible = false;
            }
            contador++;

        }

        private void button7_Click(object sender, EventArgs e)
        {            
            panel10.Visible = false;
            Reporte_de_ventas reporte = new Reporte_de_ventas();
            reporte.Show();
            this.Dispose();
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Articulos art = new Articulos();
            art.Show();
            this.Hide();
        }
        public void abriform(object formh) {
            if (this.panel3.Controls.Count > 0)
            {
                this.panel3.Controls.RemoveAt(0);
                Form fh = formh as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel3.Controls.Add(fh);
                this.panel3.Tag = fh;
                fh.Show();
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
            proveedor.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pagos pago = new Pagos();
            pago.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReporteEmpleado reporte = new ReporteEmpleado();
            reporte.Show();
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            if (Login.Acce)
            {
                panel14.Visible = true;
                if (!Articulos.Existencias) {
                    pictureBox19.Visible = true;
                    textBox1.Text = "Quedan productos con poca existencia,verifica el stock";
                }

            }
            if (!Login.Acce)
            {
                panel14.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button8.Visible = false;
                button6.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel12.Visible = false;
                panel9.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;

            }
            
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (contador2 % 2 != 0)
            {
                panel16.Visible = true;
            }
            else
            {
                panel16.Visible = false;
            }
            contador2++;

        }
    }
    }

