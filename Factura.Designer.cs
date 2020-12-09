namespace Sistema_de_ventas
{
    partial class Factura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.detallefactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Sistema_de_ventas.DataSet1();
            this.totalgastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreclientefacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ObneternumerofacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NombreEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechadeemicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.montoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CambioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.detallefactTableAdapter = new Sistema_de_ventas.DataSet1TableAdapters.detallefactTableAdapter();
            this.totalgastosTableAdapter = new Sistema_de_ventas.DataSet1TableAdapters.totalgastosTableAdapter();
            this.nombreclientefacturaTableAdapter = new Sistema_de_ventas.DataSet1TableAdapters.nombreclientefacturaTableAdapter();
            this.numNITTableAdapter = new Sistema_de_ventas.DataSet1TableAdapters.numNITTableAdapter();
            this.ObneternumerofacturaTableAdapter = new Sistema_de_ventas.DataSet1TableAdapters.ObneternumerofacturaTableAdapter();
            this.NombreEmpleadoTableAdapter = new Sistema_de_ventas.DataSet1TableAdapters.NombreEmpleadoTableAdapter();
            this.fechadeemicionTableAdapter = new Sistema_de_ventas.DataSet1TableAdapters.fechadeemicionTableAdapter();
            this.montoTableAdapter = new Sistema_de_ventas.DataSet1TableAdapters.montoTableAdapter();
            this.CambioTableAdapter = new Sistema_de_ventas.DataSet1TableAdapters.CambioTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detallefactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalgastosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreclientefacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObneternumerofacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadeemicionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CambioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // detallefactBindingSource
            // 
            this.detallefactBindingSource.DataMember = "detallefact";
            this.detallefactBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalgastosBindingSource
            // 
            this.totalgastosBindingSource.DataMember = "totalgastos";
            this.totalgastosBindingSource.DataSource = this.DataSet1;
            // 
            // nombreclientefacturaBindingSource
            // 
            this.nombreclientefacturaBindingSource.DataMember = "nombreclientefactura";
            this.nombreclientefacturaBindingSource.DataSource = this.DataSet1;
            this.nombreclientefacturaBindingSource.CurrentChanged += new System.EventHandler(this.nombreclientefacturaBindingSource_CurrentChanged);
            // 
            // numNITBindingSource
            // 
            this.numNITBindingSource.DataMember = "numNIT";
            this.numNITBindingSource.DataSource = this.DataSet1;
            // 
            // ObneternumerofacturaBindingSource
            // 
            this.ObneternumerofacturaBindingSource.DataMember = "Obneternumerofactura";
            this.ObneternumerofacturaBindingSource.DataSource = this.DataSet1;
            // 
            // NombreEmpleadoBindingSource
            // 
            this.NombreEmpleadoBindingSource.DataMember = "NombreEmpleado";
            this.NombreEmpleadoBindingSource.DataSource = this.DataSet1;
            // 
            // fechadeemicionBindingSource
            // 
            this.fechadeemicionBindingSource.DataMember = "fechadeemicion";
            this.fechadeemicionBindingSource.DataSource = this.DataSet1;
            // 
            // montoBindingSource
            // 
            this.montoBindingSource.DataMember = "monto";
            this.montoBindingSource.DataSource = this.DataSet1;
            // 
            // CambioBindingSource
            // 
            this.CambioBindingSource.DataMember = "Cambio";
            this.CambioBindingSource.DataSource = this.DataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.detallefactBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.totalgastosBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.nombreclientefacturaBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.numNITBindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.ObneternumerofacturaBindingSource;
            reportDataSource6.Name = "DataSet6";
            reportDataSource6.Value = this.NombreEmpleadoBindingSource;
            reportDataSource7.Name = "DataSet7";
            reportDataSource7.Value = this.fechadeemicionBindingSource;
            reportDataSource8.Name = "DataSet8";
            reportDataSource8.Value = this.montoBindingSource;
            reportDataSource9.Name = "DataSet9";
            reportDataSource9.Value = this.CambioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_de_ventas.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(950, 525);
            this.reportViewer1.TabIndex = 0;
            // 
            // detallefactTableAdapter
            // 
            this.detallefactTableAdapter.ClearBeforeFill = true;
            // 
            // totalgastosTableAdapter
            // 
            this.totalgastosTableAdapter.ClearBeforeFill = true;
            // 
            // nombreclientefacturaTableAdapter
            // 
            this.nombreclientefacturaTableAdapter.ClearBeforeFill = true;
            // 
            // numNITTableAdapter
            // 
            this.numNITTableAdapter.ClearBeforeFill = true;
            // 
            // ObneternumerofacturaTableAdapter
            // 
            this.ObneternumerofacturaTableAdapter.ClearBeforeFill = true;
            // 
            // NombreEmpleadoTableAdapter
            // 
            this.NombreEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // fechadeemicionTableAdapter
            // 
            this.fechadeemicionTableAdapter.ClearBeforeFill = true;
            // 
            // montoTableAdapter
            // 
            this.montoTableAdapter.ClearBeforeFill = true;
            // 
            // CambioTableAdapter
            // 
            this.CambioTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nueva venta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Menú principal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.ForeColor = System.Drawing.Color.White;
            this.Salir.Location = new System.Drawing.Point(0, 125);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(57, 42);
            this.Salir.TabIndex = 3;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 525);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detallefactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalgastosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreclientefacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObneternumerofacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechadeemicionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CambioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource detallefactBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.detallefactTableAdapter detallefactTableAdapter;
        private System.Windows.Forms.BindingSource totalgastosBindingSource;
        private DataSet1TableAdapters.totalgastosTableAdapter totalgastosTableAdapter;
        private System.Windows.Forms.BindingSource nombreclientefacturaBindingSource;
        private DataSet1TableAdapters.nombreclientefacturaTableAdapter nombreclientefacturaTableAdapter;
        private System.Windows.Forms.BindingSource numNITBindingSource;
        private DataSet1TableAdapters.numNITTableAdapter numNITTableAdapter;
        private System.Windows.Forms.BindingSource ObneternumerofacturaBindingSource;
        private DataSet1TableAdapters.ObneternumerofacturaTableAdapter ObneternumerofacturaTableAdapter;
        private System.Windows.Forms.BindingSource NombreEmpleadoBindingSource;
        private DataSet1TableAdapters.NombreEmpleadoTableAdapter NombreEmpleadoTableAdapter;
        private System.Windows.Forms.BindingSource fechadeemicionBindingSource;
        private DataSet1TableAdapters.fechadeemicionTableAdapter fechadeemicionTableAdapter;
        private System.Windows.Forms.BindingSource montoBindingSource;
        private DataSet1TableAdapters.montoTableAdapter montoTableAdapter;
        private System.Windows.Forms.BindingSource CambioBindingSource;
        private DataSet1TableAdapters.CambioTableAdapter CambioTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Salir;
    }
}