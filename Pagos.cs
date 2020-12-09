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
    public partial class Pagos : Form
    {
        CRUDmetodospago pago = new CRUDmetodospago();
        bool editar;
        bool buscar;
        bool editarPago;
        public Pagos()
        {
            InitializeComponent();
            if (!buscar) {
                Mostrar();
            }
            textBox7.Enabled = false;
            DateTime dateTime = DateTime.UtcNow.Date;
            textBox7.Text = dateTime.ToString();
        }
        private void Pagos_Load(object sender, EventArgs e)
        {

        }
        public void Mostrar() {
            CRUDmetodospago pago = new CRUDmetodospago();
           // pago.Mostrar();
            this.dataGridView1.DataSource = pago.Mostrar();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!editar) {
                    pago.Agregar(textBox1.Text);
                    MessageBox.Show("Se agregó correctamente");
                    Mostrar();
                }
                if (editar) {
                    pago.actualizar(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString()),textBox1.Text);
                    MessageBox.Show("Se actualizó correctamente");
                    Mostrar();
                    editar = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ocurrio un error "+ ex);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try {
                editar = true;
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    textBox1.Text = dataGridView1.CurrentRow.Cells["Forma_de_Pago"].Value.ToString();
                }
                else {
                    MessageBox.Show("Seleccione la fila a editar");

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ocurrió un error"+ex);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {

                    if (MessageBox.Show("¿Desea eliminar este registro?", "advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pago.eliminar(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString()));
                        MessageBox.Show("Se eliminó correctamente");
                        Mostrar();
                    }   
                }
                else
                {
                    MessageBox.Show("Seleccione la fila que desea eliminar");
                }
            }
            catch (Exception ex) {
                    MessageBox.Show("Ocurrió un error "+ex);
            }   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CRUDmetodospago procc = new CRUDmetodospago();
            try
            {
                buscar = true;
                if (textBox2.Text == "")
                {
                    MessageBox.Show("ingrese el nombre del producto");
                }
                else
                {

                    this.dataGridView1.DataSource = pago.buscar(textBox2.Text);
                }
                buscar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error" + ex);
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
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
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
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Llene los campos ID Empleado y ID pago");
            }
            else {
                try
                {
                    CRUDpagoCliente pagoc = new CRUDpagoCliente();
                    pagoc.Verificar(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                    this.dataGridView2.DataSource = pagoc.Verificar(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error " + ex);
                }
            }              
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (!editarPago) {
                    CRUDpagoCliente pagoc = new CRUDpagoCliente();
                    pagoc.agregar(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text), Convert.ToDecimal(textBox5.Text), textBox6.Text, Convert.ToDateTime(textBox7.Text));
                    MessageBox.Show("Se registró el pago correctamente");
                    Mostrar2();
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
                if (editarPago) {
                    CRUDpagoCliente pagoc = new CRUDpagoCliente();
                    pagoc.Editar(Convert.ToInt32(dataGridView2.CurrentRow.Cells["ID"].Value.ToString()) ,Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text), Convert.ToDecimal(textBox5.Text), textBox6.Text, Convert.ToDateTime(textBox7.Text));
                    MessageBox.Show("Se actualizó correctamente");
                    Mostrar2();
                    editarPago = false;
                }   
            }
            catch (Exception ex) {
                MessageBox.Show("Ocurrió un error"+ex);
            }   
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Mostrar2();
        }
        public void Mostrar2() {
            CRUDpagoCliente pagos = new CRUDpagoCliente();
            this.dataGridView2.DataSource = pagos.VerPagos();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count > 0)
            {
                editarPago = true;
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = dataGridView2.CurrentRow.Cells["Cantidad"].Value.ToString();
                textBox6.Text = dataGridView2.CurrentRow.Cells["Razón"].Value.ToString();
                textBox7.Text = dataGridView2.CurrentRow.Cells["Fecha_Emitida"].Value.ToString();
            }
            else {
                MessageBox.Show("seleccione la fila que desea editar");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try {
                if (this.dataGridView2.SelectedRows.Count > 0)
                {
                    CRUDpagoCliente pago = new CRUDpagoCliente();
                    pago.eliminar(Convert.ToInt32(dataGridView2.CurrentRow.Cells["ID"].Value.ToString()));
                    MessageBox.Show("Se eliminó el registro");
                    Mostrar2();
                }
                else
                {

                    MessageBox.Show("Seleccione la fila que desea eliminar");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ocurrió un error "+ex);
            
            }
            
        }
        }
    }

