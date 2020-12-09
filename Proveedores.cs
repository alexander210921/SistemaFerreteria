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
    public partial class Proveedores : Form
    {
        CRUDproveedor proc = new CRUDproveedor();
        bool editar;
        bool buscar=false;
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            if (buscar==false) {
                Mostrar();
            }
            if (buscar) {
             

            }
          
        }

        public void Mostrar() {
            CRUDproveedor proc1 = new CRUDproveedor();
            this.dataGridView1.DataSource = proc1.Mostrar();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            try {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {

                    MessageBox.Show("Verifique no dejar campos vacios");
                }
                else
                {

                    if (editar == false)
                    {
                        proc.Ingresar(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                        Mostrar();
                    }
                    if (editar == true)
                    {
                        proc.Editar(Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_proveedor"].Value.ToString()), textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);

                        Mostrar();

                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("ocurrio un error : "+ex);
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CRUDproveedor proc1 = new CRUDproveedor();
            try
            {

                if (textBox7.Text == "")
                {

                    MessageBox.Show("ingrese el nombre del proudcto a buscar");
                }
                else
                {
                    //buscar = ;
                    proc1.Buscar(textBox7.Text);
                    this.dataGridView1.DataSource = proc1.Buscar(textBox7.Text);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error : " + ex);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    proc.Eliminar(Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_proveedor"].Value.ToString()));
                    MessageBox.Show("se elimino correctamente");
                    Mostrar();

                }
                else
                {
                    MessageBox.Show("seleccione la fila que desee eliminar");


                }
            } catch (Exception ex) {

                MessageBox.Show("Error: "+ex);
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    editar = true;
                    textBox1.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                    textBox4.Text = dataGridView1.CurrentRow.Cells["pais"].Value.ToString();
                    textBox5.Text = dataGridView1.CurrentRow.Cells["departamento"].Value.ToString();
                    textBox6.Text = dataGridView1.CurrentRow.Cells["ubicacion"].Value.ToString();


                }
                else
                {
                    MessageBox.Show("seleccione la fila que desee editar");

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error : "+ex);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
