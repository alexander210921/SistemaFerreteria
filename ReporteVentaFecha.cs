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
    public partial class ReporteVentaFecha : Form
    {
        public ReporteVentaFecha()
        {
            InitializeComponent();
        }

        public DateTime fechainicial { get; set; }
        public DateTime fechafinal { get; set; }
        private void ReporteVentaFecha_Load(object sender, EventArgs e)
        {
        
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.ReporteventaporFecha' Puede moverla o quitarla según sea necesario.
            this.ReporteventaporFechaTableAdapter.Fill(this.DataSet1.ReporteventaporFecha,fechainicial,fechafinal);

            this.reportViewer1.RefreshReport();
        }
    }
}
