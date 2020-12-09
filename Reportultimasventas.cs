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
    public partial class Reportultimasventas : Form
    {
        public Reportultimasventas()
        {
            InitializeComponent();
        }

        private void Reportultimasventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.UltimassNventas' Puede moverla o quitarla según sea necesario.
            this.UltimassNventasTableAdapter.Fill(this.DataSet1.UltimassNventas,Datos_para_el_reporte.id);

            this.reportViewer1.RefreshReport();
        }
    }
}
