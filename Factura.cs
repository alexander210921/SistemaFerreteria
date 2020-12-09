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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
            
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Cambio' Puede moverla o quitarla según sea necesario.
            this.CambioTableAdapter.Fill(this.DataSet1.Cambio, Convert.ToInt32(Numventaactual.numero));
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.monto' Puede moverla o quitarla según sea necesario.
            this.montoTableAdapter.Fill(this.DataSet1.monto, Convert.ToInt32(Numventaactual.numero));
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.fechadeemicion' Puede moverla o quitarla según sea necesario.
            this.fechadeemicionTableAdapter.Fill(this.DataSet1.fechadeemicion, Convert.ToInt32(Numventaactual.numero));
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.NombreEmpleado' Puede moverla o quitarla según sea necesario.
            this.NombreEmpleadoTableAdapter.Fill(this.DataSet1.NombreEmpleado, Convert.ToInt32(Numventaactual.numero));
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Obneternumerofactura' Puede moverla o quitarla según sea necesario.
            this.ObneternumerofacturaTableAdapter.Fill(this.DataSet1.Obneternumerofactura, Convert.ToInt32(Numventaactual.numero));
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.numNIT' Puede moverla o quitarla según sea necesario.
            this.numNITTableAdapter.Fill(this.DataSet1.numNIT, Convert.ToInt32(Numventaactual.numero));
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.nombreclientefactura' Puede moverla o quitarla según sea necesario.
            this.nombreclientefacturaTableAdapter.Fill(this.DataSet1.nombreclientefactura, Convert.ToInt32(Numventaactual.numero));
            Registro_de_venta reg = new Registro_de_venta();
            CRUDdetallefactura detm = new CRUDdetallefactura();
            CRUDdetallefactura factu = new CRUDdetallefactura();
            
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.totalgastos' Puede moverla o quitarla según sea necesario.
            this.totalgastosTableAdapter.Fill(this.DataSet1.totalgastos, Convert.ToInt32(Numventaactual.numero));
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.detallefact' Puede moverla o quitarla según sea necesario.
            this.detallefactTableAdapter.Fill(this.DataSet1.detallefact, Convert.ToInt32(Numventaactual.numero) );
            this.reportViewer1.RefreshReport();
        }

        private void nombreclientefacturaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nueva_Venta n = new Nueva_Venta();
            n.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            ini.Show();
            this.Hide();

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
