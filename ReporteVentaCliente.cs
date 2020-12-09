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
    public partial class ReporteVentaCliente : Form
    {
        public ReporteVentaCliente()
        {
            InitializeComponent();
        }

        private void ReporteVentaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Reporteporcliente' Puede moverla o quitarla según sea necesario.
            this.ReporteporclienteTableAdapter.Fill(this.DataSet1.Reporteporcliente,Datos_para_el_reporte.id);

            this.reportViewer1.RefreshReport();
        }
    }
}
