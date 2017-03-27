namespace stokTakip.Forms
{
    partial class ReportForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.stokTakipDataSet1 = new stokTakip.stokTakipDataSet1();
            this.stokTakipDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksTableAdapter = new stokTakip.stokTakipDataSet1TableAdapters.StocksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.stocksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "stokTakip.Forms.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1187, 700);
            this.reportViewer1.TabIndex = 0;
            // 
            // stokTakipDataSet1
            // 
            this.stokTakipDataSet1.DataSetName = "stokTakipDataSet1";
            this.stokTakipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokTakipDataSet1BindingSource
            // 
            this.stokTakipDataSet1BindingSource.DataSource = this.stokTakipDataSet1;
            this.stokTakipDataSet1BindingSource.Position = 0;
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.stokTakipDataSet1;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 700);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private stokTakipDataSet1 stokTakipDataSet1;
        private System.Windows.Forms.BindingSource stokTakipDataSet1BindingSource;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private stokTakipDataSet1TableAdapters.StocksTableAdapter stocksTableAdapter;
    }
}