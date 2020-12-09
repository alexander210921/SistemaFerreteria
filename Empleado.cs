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
    public partial class Empleado : Form
    {
        CRUDempleado proc = new CRUDempleado();
        bool editar;
        public Empleado()
        {
            InitializeComponent();
            
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        public void Mostrar() {
            CRUDempleado proc1 = new CRUDempleado();
            this.dataGridView1.DataSource = proc1.Mostrar();


        }

        public void limpiar() {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            

        }
        private void button1_Click(object sender, EventArgs e)
            
        {

            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                try
                {
                    pictureBox5.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch (Exception ex) {
                    MessageBox.Show("Elija una foto para el empleado");

                }
                

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox12.Text == ""||comboBox1.Text=="")
                {
                    MessageBox.Show("Asegurate de no dejar campos vacios");
                }
                else
                {
                    if (editar == false)
                    {

                   
                        proc.Insertar(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDateTime(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt64(textBox6.Text), Convert.ToDouble(textBox7.Text), textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, comboBox1.SelectedItem.ToString(),ms.GetBuffer());
                        MessageBox.Show("Completado con exito");
                        limpiar();
                        Mostrar();

                    }
                    if (editar == true)
                    {
                        proc.Editar(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString()), textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDateTime(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt64(textBox6.Text), Convert.ToDouble(textBox7.Text), textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, comboBox1.SelectedItem.ToString(), ms.GetBuffer());
                        MessageBox.Show("Completado con exito");
                        limpiar();
                        Mostrar();
                        editar = false;
                    }

                }
            }
            catch (Exception ex) {

                MessageBox.Show("se produjo un error "+ex);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        proc.Eliminar(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString()));
                        MessageBox.Show("Eliminado correctamente");
                        Mostrar();

                    }

                }
                else
                {
                    MessageBox.Show("Eliga la fila a eliminar");



                }
            }
            catch (Exception ex) {
                MessageBox.Show("se produjo un error "+ex);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    editar = true;
                    textBox1.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString();
                    textBox4.Text = dataGridView1.CurrentRow.Cells["Fecha_nacimiento"].Value.ToString();
                    textBox5.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                    textBox6.Text = dataGridView1.CurrentRow.Cells["DPI"].Value.ToString();
                    textBox7.Text = dataGridView1.CurrentRow.Cells["Salario"].Value.ToString();
                    textBox8.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                    textBox9.Text = dataGridView1.CurrentRow.Cells["Pais"].Value.ToString();
                    textBox10.Text = dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString();
                    textBox11.Text = dataGridView1.CurrentRow.Cells["Ubicacion"].Value.ToString();
                    textBox12.Text = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
                    textBox13.Text = dataGridView1.CurrentRow.Cells["Contraseña"].Value.ToString();
                    comboBox1.Text = "";
                    
                }
                else
                {

                    MessageBox.Show("Eliga la fila a editar");
                }

            }
            catch (Exception ex) {
                MessageBox.Show("se produjo un error "+ex);

            }
                    }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox15.Text == "")
                {

                    MessageBox.Show("ingrese el nombre del producto");

                }
                else
                {
                    CRUDempleado proc2 = new CRUDempleado();
                    dataGridView1.DataSource = proc2.Buscar(textBox15.Text);


                }
            }
            catch (Exception ex) {
                MessageBox.Show("se produjo un error"+ ex);

            }
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult res = op.ShowDialog();
            if (res==DialogResult.OK) {
                pictureBox5.Image = Image.FromFile(op.FileName);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
