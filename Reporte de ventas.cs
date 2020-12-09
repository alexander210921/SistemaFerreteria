using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas
{
    public partial class Reporte_de_ventas : Form
    {
        public static string texto;
        public static int numopcion;

        public Reporte_de_ventas()
        {
            InitializeComponent();
            Reporte_Pagos.Pago = false;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            pictureBox2.Visible = true;
            pictureBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numopcion = 1;
            texto = "ID Cliente";
            Datos_para_el_reporte dato = new Datos_para_el_reporte();
            dato.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numopcion = 2;
            texto = "ID Empleado";
            Datos_para_el_reporte rep = new Datos_para_el_reporte();
            rep.Show();
            

            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            numopcion = 3;
            texto = "Ingrese la fecha";
            Datos_para_el_reporte rep = new Datos_para_el_reporte();
            rep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numopcion = 4;
            texto = "NO.Venta";
            Datos_para_el_reporte rep = new Datos_para_el_reporte();
            rep.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numopcion = 5;
            texto = "Cantidad de Ventas";
            Datos_para_el_reporte rep = new Datos_para_el_reporte();
            rep.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numopcion = 6;
            texto = "Cantidad de Ventas";
            Datos_para_el_reporte rep = new Datos_para_el_reporte();
            rep.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Inicio inic = new Inicio();
            inic.Show();
            this.Hide();
        }
    }
}
