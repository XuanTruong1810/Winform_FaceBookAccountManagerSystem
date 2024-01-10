using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLTKDataSet.Comments' table. You can move, or remove it, as needed.
            this.CommentsTableAdapter.Fill(this.QLTKDataSet.Comments);
            // TODO: This line of code loads data into the 'QLTKDataSet.Posts' table. You can move, or remove it, as needed.
            this.PostsTableAdapter.Fill(this.QLTKDataSet.Posts);
            // TODO: This line of code loads data into the 'QLTKDataSet.Accounts' table. You can move, or remove it, as needed.
            this.AccountsTableAdapter.Fill(this.QLTKDataSet.Accounts);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
    }
}
