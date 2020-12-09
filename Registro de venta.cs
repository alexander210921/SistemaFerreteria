using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_de_ventas
{
    public partial class Registro_de_venta : Form
    {
        
        Venta venta = new Venta();
        VerificarDatos veri = new VerificarDatos();
        bool estatusTotal;
        public string totalgastos;
        bool estadoPruena;
        bool Existencia;

        public Registro_de_venta()
        {
            InitializeComponent();
            textBox3.Text = IDuser.id;
            textBox6.Text = Numventaactual.numero;
            label8.Text = "Venta No. " + Numventaactual.numero;

            DateTime dateTime = DateTime.UtcNow.Date;
            textBox4.Text = dateTime.ToString();
            textBox11.Text = "0";           
            textBox8.Text = "0";
            textBox12.Text = "0";
            textBox12.Text = "0";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!Existencia)
            {
                MessageBox.Show("No hay existencias de este prodcuto");
            }
            else {
                textBox11.Enabled = true;
                estatusTotal = true;
                if (textBox1.Text == "" || textBox2.Text == "" || textBox7.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("verifique no dejar campos obligatorios en blanco");
                }

                else
                {
                    try
                    {



                        estadoPruena = true;
                        CRUDdetallefactura factura = new CRUDdetallefactura();
                        factura.Insertar(Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox7.Text), Convert.ToDateTime(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToDecimal(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox12.Text), Convert.ToDecimal(textBox11.Text), Convert.ToDecimal(textBox8.Text));
                        MessageBox.Show("se agregó correctamente");
                        MessageBox.Show("puedes seguir agregando productos o facturar");
                        textBox1.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox7.Enabled = false;
                        textBox10.Enabled = false;
                        factura.Updateexistencias(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox5.Text));
                        button2.Enabled = true;
                        textBox2.Text = "";
                        textBox5.Text = "";
                        textBox9.Text = "0";
                        CRUDdetallefactura factu = new CRUDdetallefactura();
                        factu.TOTAL(Convert.ToInt32(textBox6.Text));
                        textBox12.Text = factu.total;
                        totalgastos = factu.total; ;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }

            }
            
          
            
        }

        private void Registro_de_venta_Load(object sender, EventArgs e)
        {

            
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox6.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;

        }
    
        private void button3_Click(object sender, EventArgs e)
            {
            
            try {
                if (textBox7.Text == "")
                {
                    MessageBox.Show("Verifique no dejar campos vacios");
                }
                else {
                    ProcedimientosDeVerificacion proc = new ProcedimientosDeVerificacion();
                    proc.formapago(Convert.ToInt32(textBox7.Text));
                    this.dataGridView1.DataSource = proc.formapago(Convert.ToInt32(textBox7.Text));
                    label7.Visible = true;
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show("error "+ex);
            } 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox11.Text) < Convert.ToInt32(textBox12.Text))
            {
                MessageBox.Show("El monto a pagar es menor al TOTAL, favor de verificar");
            }
            else {

                if (true)
                {
                    decimal vuelto = Convert.ToDecimal(textBox11.Text) - Convert.ToInt32(textBox12.Text);
                    textBox8.Text = vuelto.ToString();
                }
                CRUDdetallefactura detall = new CRUDdetallefactura();
                detall.vuelto(Convert.ToDecimal(textBox8.Text), Convert.ToInt32(textBox6.Text));
                detall.Montpagar(Convert.ToDecimal(textBox11.Text), Convert.ToInt32(textBox6.Text));

                Factura mostrar = new Factura();
                mostrar.Show();
                this.Hide();

                detall.PagoVuelto(Convert.ToInt32(textBox6.Text), Convert.ToDecimal(textBox11.Text), Convert.ToDecimal(textBox8.Text), Convert.ToInt32(textBox12.Text));
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          


            ProcedimientosDeVerificacion proc = new ProcedimientosDeVerificacion();
            if (textBox10.Text=="") {
                textBox10.Text = "0";
            }
            if (textBox1.Text=="") {
                MessageBox.Show("Verifique no dejar campos obligatorios vacios");
            }
            try {
                this.dataGridView1.DataSource = proc.nombrecliente(Convert.ToInt32(textBox1.Text));
            }catch(Exception ex) {
                MessageBox.Show("error "+ex);
            
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            ProcedimientosDeVerificacion proc1 = new ProcedimientosDeVerificacion();
            if (textBox2.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Verifique no dejar campos obligatorios vacios");
            }
            else { 
            try
            {
                    estadoPruena = true;
                    this.dataGridView1.DataSource = proc1.nombreproducto(Convert.ToInt32(textBox2.Text));
                proc1.preciounitario(Convert.ToInt32(textBox2.Text));
                textBox9.Text = proc1.preci;
                    CRUDdetallefactura factu = new CRUDdetallefactura();
                    factu.TOTAL(Convert.ToInt32(textBox6.Text));
                    if (estadoPruena) {
                        button1.Enabled = true;
                    }
                    //   textBox12.Text = factu.total;
                }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex);

            }




            }
                    }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name =="Cantidad")
            {
                if (Convert.ToInt32(e.Value) <= 10)
                {
                    Existencia = true;
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;
                    if (Convert.ToInt32(e.Value) <= 0) {

                        Existencia = false;
                    
                    }
                    
                }
                if (Convert.ToInt32(e.Value) <= 20 && Convert.ToInt32(e.Value) > 10)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Gray;
                    Existencia = true;

                }
                if (Convert.ToInt32(e.Value) > 20)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Green;
                    Existencia = true;

                }

            }
        }
    }
}
