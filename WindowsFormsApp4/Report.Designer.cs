
namespace WindowsFormsApp4
{
    partial class Report
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.QLTKDataSet = new WindowsFormsApp4.QLTKDataSet();
            this.AccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccountsTableAdapter = new WindowsFormsApp4.QLTKDataSetTableAdapters.AccountsTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PostsTableAdapter = new WindowsFormsApp4.QLTKDataSetTableAdapters.PostsTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CommentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommentsTableAdapter = new WindowsFormsApp4.QLTKDataSetTableAdapters.CommentsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLTKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1014, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tài Khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1014, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bài đăng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AccountsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp4.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1008, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1014, 492);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bình luận";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // QLTKDataSet
            // 
            this.QLTKDataSet.DataSetName = "QLTKDataSet";
            this.QLTKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AccountsBindingSource
            // 
            this.AccountsBindingSource.DataMember = "Accounts";
            this.AccountsBindingSource.DataSource = this.QLTKDataSet;
            // 
            // AccountsTableAdapter
            // 
            this.AccountsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PostsBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApp4.Report.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1008, 486);
            this.reportViewer2.TabIndex = 0;
            // 
            // PostsBindingSource
            // 
            this.PostsBindingSource.DataMember = "Posts";
            this.PostsBindingSource.DataSource = this.QLTKDataSet;
            // 
            // PostsTableAdapter
            // 
            this.PostsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.CommentsBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "WindowsFormsApp4.Report.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1014, 492);
            this.reportViewer3.TabIndex = 0;
            // 
            // CommentsBindingSource
            // 
            this.CommentsBindingSource.DataMember = "Comments";
            this.CommentsBindingSource.DataSource = this.QLTKDataSet;
            // 
            // CommentsTableAdapter
            // 
            this.CommentsTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 530);
            this.Controls.Add(this.tabControl1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QLTKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource AccountsBindingSource;
        private QLTKDataSet QLTKDataSet;
        private QLTKDataSetTableAdapters.AccountsTableAdapter AccountsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource PostsBindingSource;
        private QLTKDataSetTableAdapters.PostsTableAdapter PostsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource CommentsBindingSource;
        private QLTKDataSetTableAdapters.CommentsTableAdapter CommentsTableAdapter;
    }
}