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
    public partial class Articulos : Form
    {
        CRUDproducto proc = new CRUDproducto();
        Clientes formcliente = new Clientes();
        Proveedores formproveedor = new Proveedores();
        Empleado formempleado = new Empleado();
        Registro_de_venta registro = new Registro_de_venta();
        private string idProducto = null;
         bool editar=false;
        public static bool Existencias = true ;

        public Articulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            mostrarproducto();
            if (!Login.Acce)
            {
                button3.Visible = false;
                button5.Visible = false;

            }
            textBox11.Enabled = false;
            textBox11.Text = IDuser.id;
            DateTime dateTime = DateTime.UtcNow.Date;
            textBox9.Enabled = false;
            textBox9.Text = dateTime.ToString();


        }
        //funciones creadas para la tabla producto
        public void mostrarproducto() {
            CRUDproducto Proc = new CRUDproducto();
            this.dataGridView1.DataSource = Proc.Mostrar();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Asegurate de no dejar un campo vacio");
                }
                else {
                    if (editar == false)
                    {
                        button1.Text = "Guardar";
                        proc.Insertar(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),textBox3.Text,textBox4.Text,Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox7.Text),Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text),Convert.ToDateTime(textBox9.Text));
                        MessageBox.Show("Completado con exito");
                        Limpiar();
                        mostrarproducto();

                    }


                    if (editar == true)
                    {
                        button1.Text = "Guardar Cambios";
                        proc.Modificar(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString()),Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text, Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox7.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text), Convert.ToDateTime(textBox9.Text));
                        MessageBox.Show("Completado con exito");
                        Limpiar();
                        mostrarproducto();
                        editar = false;
                    }

                }
               


            }
            catch (Exception ex) {

                MessageBox.Show("Eror, error de ingreso de los datos : " + ex);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            CRUDproducto procc = new CRUDproducto();
            try {
                if (textBox6.Text == "")
                {
                    MessageBox.Show("ingrese el nombre del producto");
                }
                else
                {
                    procc.buscarproducto(textBox6.Text);
                    this.dataGridView1.DataSource = procc.buscarproducto(textBox6.Text);
                }
            }
            catch (Exception ex) {

                MessageBox.Show("Error"+ex);

            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {

            mostrarproducto();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    button3.Enabled = true;
                    idProducto = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    proc.Eliminar(Convert.ToInt32(idProducto));
                    MessageBox.Show("Eliminado correctamente");
                    mostrarproducto();

                }
                else
                {


                    MessageBox.Show("seleccione la fila a eliminar");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error "+ex);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    editar = true;

                    textBox1.Text = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells["Proveedor"].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                    textBox4.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                    textBox5.Text = dataGridView1.CurrentRow.Cells["PrecioCompra"].Value.ToString();
                    textBox8.Text = dataGridView1.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                    textBox7.Text = dataGridView1.CurrentRow.Cells["Descuento"].Value.ToString();
                    textBox10.Text = dataGridView1.CurrentRow.Cells["Existencia"].Value.ToString();
                    textBox11.Text = dataGridView1.CurrentRow.Cells["Ingresado_Por"].Value.ToString();
                    textBox9.Text = dataGridView1.CurrentRow.Cells["FechaRegistro"].Value.ToString();

                }
                else
                {
                    MessageBox.Show("seleccione la fila a editar");


                }

            }
            catch (Exception ex) {

                MessageBox.Show("Error: "+ex);
            }
                    }

        private void button6_Click(object sender, EventArgs e)
        {
            //formproveedor.Show();
            //formempleado.Show();
            registro.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name=="Existencia") {
                if (Convert.ToInt32(e.Value)<=10) {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;
                    Existencias = false;
                }
                if (Convert.ToInt32(e.Value)<=20 && Convert.ToInt32(e.Value) > 10)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Gray;
                    Existencias = true;
                }
                if (Convert.ToInt32(e.Value) > 20) {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Green;
                    Existencias = true;
                }

            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void Limpiar() {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox9.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Show();
            this.Hide();   
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
