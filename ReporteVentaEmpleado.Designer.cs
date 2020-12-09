namespace Sistema_de_ventas
{
    partial class ReporteVentaEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentaEmpleado));
            this.ReporteventaporEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Sistema_de_ventas.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteventaporEmpleadoTableAdapter = new Sistema_de_ventas.DataSet1TableAdapters.ReporteventaporEmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteventaporEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteventaporEmpleadoBindingSource
            // 
            this.ReporteventaporEmpleadoBindingSource.DataMember = "ReporteventaporEmpleado";
            this.ReporteventaporEmpleadoBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteventaporEmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_de_ventas.ReporteporEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteventaporEmpleadoTableAdapter
            // 
            this.ReporteventaporEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVentaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteVentaEmpleado";
            this.Text = "ReporteVentaEmpleado";
            this.Load += new System.EventHandler(this.ReporteVentaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteventaporEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteventaporEmpleadoBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.ReporteventaporEmpleadoTableAdapter ReporteventaporEmpleadoTableAdapter;
    }
}