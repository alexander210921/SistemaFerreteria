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
    public partial class Reporte_por_factura : Form
    {
        public Reporte_por_factura()
        {
            InitializeComponent();
        }

        private void Reporte_por_factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Informepornumventa' Puede moverla o quitarla según sea necesario.
            this.InformepornumventaTableAdapter.Fill(this.DataSet1.Informepornumventa,Datos_para_el_reporte.id);

            this.reportViewer1.RefreshReport();
        }
    }
}
