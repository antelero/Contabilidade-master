namespace Apresentacao
{
    partial class frmRelatorioUEPS
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
            this.uvwEstoquePEPSCarregarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetControleEstoque = new Apresentacao.DataSetControleEstoque();
            this.uvwEstoqueUEPSCarregarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uvwEstoqueCustoMedioCarregarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uvwEstoquePEPSCarregarTableAdapter = new Apresentacao.DataSetControleEstoqueTableAdapters.uvwEstoquePEPSCarregarTableAdapter();
            this.uvwEstoqueUEPSCarregarTableAdapter = new Apresentacao.DataSetControleEstoqueTableAdapters.uvwEstoqueUEPSCarregarTableAdapter();
            this.uvwEstoqueCustoMedioCarregarTableAdapter = new Apresentacao.DataSetControleEstoqueTableAdapters.uvwEstoqueCustoMedioCarregarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uvwEstoquePEPSCarregarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetControleEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvwEstoqueUEPSCarregarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvwEstoqueCustoMedioCarregarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uvwEstoquePEPSCarregarBindingSource
            // 
            this.uvwEstoquePEPSCarregarBindingSource.DataMember = "uvwEstoquePEPSCarregar";
            this.uvwEstoquePEPSCarregarBindingSource.DataSource = this.DataSetControleEstoque;
            // 
            // DataSetControleEstoque
            // 
            this.DataSetControleEstoque.DataSetName = "DataSetControleEstoque";
            this.DataSetControleEstoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uvwEstoqueUEPSCarregarBindingSource
            // 
            this.uvwEstoqueUEPSCarregarBindingSource.DataMember = "uvwEstoqueUEPSCarregar";
            this.uvwEstoqueUEPSCarregarBindingSource.DataSource = this.DataSetControleEstoque;
            // 
            // uvwEstoqueCustoMedioCarregarBindingSource
            // 
            this.uvwEstoqueCustoMedioCarregarBindingSource.DataMember = "uvwEstoqueCustoMedioCarregar";
            this.uvwEstoqueCustoMedioCarregarBindingSource.DataSource = this.DataSetControleEstoque;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPEPS";
            reportDataSource1.Value = this.uvwEstoquePEPSCarregarBindingSource;
            reportDataSource2.Name = "DataSetUEPS";
            reportDataSource2.Value = this.uvwEstoqueUEPSCarregarBindingSource;
            reportDataSource3.Name = "DataSetCM";
            reportDataSource3.Value = this.uvwEstoqueCustoMedioCarregarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Apresentacao.rpRelatorioUEPS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1047, 620);
            this.reportViewer1.TabIndex = 0;
            // 
            // uvwEstoquePEPSCarregarTableAdapter
            // 
            this.uvwEstoquePEPSCarregarTableAdapter.ClearBeforeFill = true;
            // 
            // uvwEstoqueUEPSCarregarTableAdapter
            // 
            this.uvwEstoqueUEPSCarregarTableAdapter.ClearBeforeFill = true;
            // 
            // uvwEstoqueCustoMedioCarregarTableAdapter
            // 
            this.uvwEstoqueCustoMedioCarregarTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioUEPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 700);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioUEPS";
            this.Load += new System.EventHandler(this.frmRelatorioUEPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uvwEstoquePEPSCarregarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetControleEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvwEstoqueUEPSCarregarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvwEstoqueCustoMedioCarregarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uvwEstoquePEPSCarregarBindingSource;
        private DataSetControleEstoque DataSetControleEstoque;
        private System.Windows.Forms.BindingSource uvwEstoqueUEPSCarregarBindingSource;
        private System.Windows.Forms.BindingSource uvwEstoqueCustoMedioCarregarBindingSource;
        private DataSetControleEstoqueTableAdapters.uvwEstoquePEPSCarregarTableAdapter uvwEstoquePEPSCarregarTableAdapter;
        private DataSetControleEstoqueTableAdapters.uvwEstoqueUEPSCarregarTableAdapter uvwEstoqueUEPSCarregarTableAdapter;
        private DataSetControleEstoqueTableAdapters.uvwEstoqueCustoMedioCarregarTableAdapter uvwEstoqueCustoMedioCarregarTableAdapter;
    }
}