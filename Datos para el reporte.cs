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
    
    public partial class Datos_para_el_reporte : Form
    {
        public static  int id;
        Reporte_de_ventas reporte = new Reporte_de_ventas();

        public Datos_para_el_reporte()
        {
            InitializeComponent();
            if (Reporte_Pagos.Pago) {
                label2.Text = Reporte_Pagos.texto;
            }
            if (!Reporte_Pagos.Pago) {
                label2.Text = Reporte_de_ventas.texto;
            }
            
            if (Reporte_de_ventas.numopcion == 3)
            {
                textBox1.Visible = false;
                label2.Visible = false;
                this.dateTimePicker1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                 this.dateTimePicker2.Visible = true;
            }
        }
        private void Datos_para_el_reporte_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Reporte_de_ventas.numopcion ==1) {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("No deje el campo vacio");
                }
                else
                {
                    try {

                        id = Convert.ToInt32(textBox1.Text);
                        ReporteVentaCliente reporte = new ReporteVentaCliente();
                        reporte.Show();
                        this.Hide();
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Se espera que ingrese un numero");

                    }


                }
            }
            if (Reporte_de_ventas.numopcion == 2) {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("No deje el campo vacio");
                }
                else
                {
                    try {
                        id = Convert.ToInt32(textBox1.Text);
                        ReporteVentaEmpleado reporte = new ReporteVentaEmpleado();
                        reporte.Show();
                        this.Hide();
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Se espera que ingrese un numero");
                    }
                    
                }
            }
            if (Reporte_de_ventas.numopcion == 3) {

                textBox1.Visible = false;
                this.dateTimePicker1.Visible = true;
                ReporteVentaFecha reporte = new ReporteVentaFecha();
                reporte.fechainicial = this.dateTimePicker1.Value;
                reporte.fechafinal = this.dateTimePicker2.Value;
                reporte.Show();
                this.Hide();
            }
            if (Reporte_de_ventas.numopcion == 4)
            {
                try
                {
                    id = Convert.ToInt32(textBox1.Text);

                    Reporte_por_factura reporte = new Reporte_por_factura();
                    reporte.Show();
                    this.Hide();
                }
                catch (Exception ex){
                    MessageBox.Show("Se esperaba que ingresara un numero");
                }
            }

            if (Reporte_de_ventas.numopcion == 5)
            {
                try
                {
                    id = Convert.ToInt32(textBox1.Text);
                    Primeras_Ventas reporte = new Primeras_Ventas();
                    reporte.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se esperaba que ingresara un numero");
                }     
            }
            if (Reporte_de_ventas.numopcion == 6)
            {
                try
                {
                    id = Convert.ToInt32(textBox1.Text);
                    Reportultimasventas reporte = new Reportultimasventas();
                    reporte.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se esperaba que ingresara un numero");
                }


            }

            if (Reporte_Pagos.numopcion==1) {
                try
                {
                    label2.Text = Reporte_Pagos.texto;

                    id = Convert.ToInt32(textBox1.Text);
                    Reportultimasventas reporte = new Reportultimasventas();
                    reporte.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se esperaba que ingresara un numero");
                }

            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
