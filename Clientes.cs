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
    public partial class Clientes : Form
    {
        CRUDcliente proc = new CRUDcliente();
        private string id = null;
        bool editar;
        public Clientes()
        {
            InitializeComponent();
        }

        private void FCliente_Load(object sender, EventArgs e)
        {
            Mostrar();
            if (!Login.Acce) {
                button3.Visible = false;
                button4.Visible = false;
            }
        }
        public void Mostrar() {

            CRUDcliente Proc = new CRUDcliente();
            this.dataGridView1.DataSource = Proc.Mostrar();

        }
        public void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            
        {
            try {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                {

                    MessageBox.Show("Asegurese de no dejar un campo vacio");
                }
                else
                {
                    if (editar == false)
                    {

                        try
                        {
                            proc.Ingresar(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                            MessageBox.Show("Completado con exito");
                            Limpiar();
                            Mostrar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Eror no se completo la operacion " + ex);
                        }



                    }
                    if (editar == true)
                    {
                        proc.Editar(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString()), textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                        MessageBox.Show("Completado con exito");
                        Limpiar();
                        Mostrar();
                        editar = false;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("ocurrio un error "+ex);
            }

            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            CRUDcliente procc = new CRUDcliente();
            try
            {
                if (textBox8.Text == "")
                {
                    MessageBox.Show("ingrese el nombre del producto");
                }
                else
                {
                    procc.Buscar(textBox8.Text);
                    this.dataGridView1.DataSource = procc.Buscar(textBox8.Text);
                }
            }
            catch (Exception ex) {

                MessageBox.Show("ocurrio un error"+ex);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    id = dataGridView1.CurrentRow.Cells["iD"].Value.ToString();
                    proc.Eliminar(Convert.ToInt32(id));
                    MessageBox.Show("se elimino correctamente el registro");
                    Mostrar();
                }
                else
                {
                    MessageBox.Show("Seleccie la fila que desee eliminar");
                }
            }
            catch (Exception ex) {

                MessageBox.Show("ocurrio un error "+ex);
            
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    editar = true;
                    textBox1.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
                    textBox4.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                    textBox5.Text = dataGridView1.CurrentRow.Cells["pais"].Value.ToString();
                    textBox6.Text = dataGridView1.CurrentRow.Cells["departamento"].Value.ToString();
                    textBox7.Text = dataGridView1.CurrentRow.Cells["ubicacion"].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Seleccie la fila que desee editar");

                }
            }
            catch (Exception ex) {
                MessageBox.Show("ocurrio un error"+ex);

            }
            




        }

        private void button6_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
