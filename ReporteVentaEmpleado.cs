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
    public partial class ReporteVentaEmpleado : Form
    {
        public ReporteVentaEmpleado()
        {
            InitializeComponent();
        }

        private void ReporteVentaEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.ReporteventaporEmpleado' Puede moverla o quitarla según sea necesario.
            this.ReporteventaporEmpleadoTableAdapter.Fill(this.DataSet1.ReporteventaporEmpleado,Datos_para_el_reporte.id);

            this.reportViewer1.RefreshReport();
        }
    }
}
