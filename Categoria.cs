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
    public partial class Categoria : Form
    {
        bool editar;
        public Categoria()
        {
            InitializeComponent();
            Mostrar();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la categoria");
            }
            else {
                if (!editar) {

                    try
                    {
                        CRUDcategoria categoria = new CRUDcategoria();
                        categoria.Insertar(textBox1.Text);
                        MessageBox.Show("Se agregó Correctamente");
                        Mostrar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error " + ex);
                    }
                }
                if (editar)
                {

                    CRUDcategoria categoria = new CRUDcategoria();
                    categoria.Actualizar(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString()),textBox1.Text);
                    editar = false;
                    Mostrar();
                }
                }
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

        private void Categoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.VerCategorias' Puede moverla o quitarla según sea necesario.
            this.verCategoriasTableAdapter.Fill(this.dataSet11.VerCategorias);
            if (!Login.Acce) {
                button2.Visible = false;
                button3.Visible = false;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    editar = true;
                    textBox1.Text = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione la fila que desea editar");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ocurrió un error "+ ex);
            }
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Mostrar() {
            CRUDcategoria cat = new CRUDcategoria();
            this.dataGridView1.DataSource = cat.mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    CRUDcategoria cat = new CRUDcategoria();
                    cat.eliminar(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString()));
                    MessageBox.Show("Se eliminó correctamente");
                    Mostrar();
                }
                else
                {
                    MessageBox.Show("Selecciole la fila que desea eliminar");
                }

                
            }
            catch (Exception ex) {

                MessageBox.Show("Ocurrió un error "+ ex);
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la categoria");
            }
            else {
                try
                {
                    CRUDcategoria categ = new CRUDcategoria();
                    this.dataGridView1.DataSource = categ.buscar(textBox2.Text);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrió un error " + ex);
                }


            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Articulos art = new Articulos();
            art.Show();
            this.Dispose();
        }
    }
}
