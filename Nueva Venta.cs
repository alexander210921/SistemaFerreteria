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
    public partial class Nueva_Venta : Form
    {
        public Nueva_Venta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas();
            Numventaactual n = new Numventaactual();
            try {
                v.NuevaVenta(textBox1.Text);
                n.numventa();
                Registro_de_venta resgis = new Registro_de_venta();
                resgis.Show();
                this.Hide();
            }
            catch (Exception ex) {
                MessageBox.Show("Error "+ex);
            
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
    }
}
